using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using System.Linq;
using RandomVehicles.GUI;

namespace RandomVehicles
{
    public class RandomVehicles : Script
    {

        private Random random = new Random();
        private long tick = 0;
        private bool keysActive = false;
        private bool doing = true;
        private bool showStartupMessages = true;

        private List<VehicleHash> availableVehicles = new List<VehicleHash>();
        private List<VehicleHash> availableBoats = new List<VehicleHash>();
        private List<VehicleHash> availablePlanes = new List<VehicleHash>();
        private List<VehicleHash> availableHelis = new List<VehicleHash>();

        private uint[] allWeapons;
        private WeaponTint[] allWeaponTints;
        private VehicleColor[] allVehicleColors;

        private int carsCount = 0;
        private int weaponsCount = 0;

        private HashSet<int> processedPeds = new HashSet<int>();
        private Config config = new Config();
        private IGUI gui;

        public RandomVehicles()
        {
            Initialize();
            this.Tick += onTick;
            this.KeyUp += onKeyUp;
            this.KeyDown += onKeyDown;
        }

        private void onTick(object sender, EventArgs e)
        {
            if (doing) tick++;

            //if (tick % 100 == 0)
            carsCount = ChangeCars();
            if (config.randomizeWeapons) weaponsCount = GiveRandomWeapons();

            if (config.debugMode) gui.Draw(carsCount + " Cars changed, " + weaponsCount + " Peds equipped", tick.ToString());

            // To show notifications after starting the game
            if (showStartupMessages && !Game.IsLoading && Game.Player.CanControlCharacter)
            {
                gui.ShowStartupMessages();
                showStartupMessages = false;
            }
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (config.debugMode && e.KeyCode == Keys.PageUp) ActivateKeys(true);

            if (!keysActive) return;
            switch (e.KeyCode)
            {
                case Keys.PageDown:
                    ActivateKeys(false);
                    break;
                case Keys.NumPad0:
                    break;
                case Keys.NumPad1:
                    SpawnTestCar();
                    break;
                case Keys.NumPad2:
                    ChangeCars();
                    break;
                case Keys.NumPad3:
                    doing = false;
                    break;
                case Keys.NumPad4:
                    UpgradeVehicle(Game.Player.Character.CurrentVehicle);
                    break;
                case Keys.NumPad5:
                    VehicleLoader.SaveToFile("scripts//RandomVehicles.txt", availableVehicles);
                    break;
                case Keys.NumPad6:
                    //UI.ShowSubtitle(config.ReadConfig(), 3000);
                    break;
                case Keys.NumPad7:
                    //UI.ShowSubtitle(config.WriteConfig(), 3000);
                    break;
                case Keys.NumPad8:
                    PausePeds();
                    break;
                case Keys.NumPad9:
                    RemoveAllCars();
                    RemoveAllPeds();
                    break;
            }
        }


        private void Initialize()
        {
            bool errors = false;

            // Init config
            List<string> configErrors = config.ReadConfig();

            // Init GUI
            if (config.renderText)
            {
                gui = new TextGUI();
            }
            else
            {
                gui = new NoGUI();
            }

            // Show config errors if there are any
            int i = 0;
            foreach (string configError in configErrors)
            {
                if (configError == "") continue;
                i++;
                errors = true;
                //Notification.Show(i.ToString() + ": " + configError);
                gui.AddStartupMessage(1, i.ToString() + ": " + configError);
            }

            allWeapons = Weapons.getWeaponHashes();
            allWeaponTints = Enum.GetValues(typeof(WeaponTint)).Cast<WeaponTint>().ToArray();
            allVehicleColors = Enum.GetValues(typeof(VehicleColor)).Cast<VehicleColor>().ToArray();

            FindAllAvailableVehicles();

            if (config.customVehicleList || config.debugMode)
            {
                gui.AddStartupMessage(1, "Cars: " + availableVehicles.Count);
                gui.AddStartupMessage(1, "Boats: " + availableBoats.Count);
                gui.AddStartupMessage(1, "Planes: " + availablePlanes.Count);
                gui.AddStartupMessage(1, "Helicopters: " + availableHelis.Count);
            }

            if (config.customVehicleList)
            {
                bool hasErrors = false;
                if (availableVehicles.Count == 0)
                {
                    gui.ShowNotification("[LAND VEHICLES] section has no valid entries!");
                    hasErrors = true;
                }

                if (config.specialClasses)
                {
                    if (availableBoats.Count == 0)
                    {
                        gui.ShowNotification("[BOATS] section has no valid entries!");
                        hasErrors = true;
                    }
                    if (availablePlanes.Count == 0)
                    {
                        gui.ShowNotification("[PLANES] section has no valid entries!");
                        hasErrors = true;
                    }
                    if (availableHelis.Count == 0)
                    {
                        gui.ShowNotification("[HELICOPTERS] section has no valid entries!");
                        hasErrors = true;
                    }
                }

                if (hasErrors)
                {
                    gui.ShowNotification("Loading custom vehicle list failed. Using the built-in list instead.");
                    config.customVehicleList = false;
                    FindAllAvailableVehicles();
                }
            }

            //GTA.UI.Screen.ShowSubtitle("RandomVehicles.dll initiated " + (errors ? "with errors" : "sucessfully"), 5000);
            gui.AddStartupMessage(0, "RandomVehicles.dll initiated " + (errors ? "with errors" : "sucessfully"));
        }


        private void FindAllAvailableVehicles()
        {
            List<List<VehicleHash>> allAvailableVehicles;
            if (config.customVehicleList)
            {
                allAvailableVehicles = VehicleLoader.LoadFromFile("scripts//RandomVehiclesList.txt", config.specialClasses, config.trailers);
                if (allAvailableVehicles.Count == 0) return;
            }
            else
            {
                if (config.dlcVehicles)
                {
                    allAvailableVehicles = VehicleClasses.GetVehicleList(config.specialClasses, config.trailers);
                }
                else
                {
                    allAvailableVehicles = VehicleClassesVanilla.GetVehicleList(config.specialClasses, config.trailers);
                }
            }

            availableVehicles = allAvailableVehicles[0];
            availableBoats = allAvailableVehicles[1];
            availablePlanes = allAvailableVehicles[2];
            availableHelis = allAvailableVehicles[3];
        }


        private void ActivateKeys(bool activate)
        {
            if (activate && !keysActive)
            {
                keysActive = true;
                gui.ShowSubtitle("Keys Activated", 4000);
            }
            else if (!activate && keysActive)
            {
                keysActive = false;
                gui.ShowSubtitle("Keys Deactivated", 4000);
            }
        }


        private void RemoveAllPeds()
        {
            Ped[] allPeds = World.GetAllPeds();
            foreach (Ped ped in allPeds)
            {
                if (!ped.Equals(Game.Player.Character))
                {
                    //ped.IsPersistent = false;
                    //Function.Call(Hash.SET_ENTITY_AS_NO_LONGER_NEEDED, ped);
                    ped.Delete();
                }
            }
        }


        private void PausePeds()
        {
            Ped[] allPeds = World.GetAllPeds();
            foreach (Ped ped in allPeds)
            {
                if (!ped.Equals(Game.Player.Character))
                {
                    Function.Call(Hash.TASK_PAUSE, ped, 1000);
                }
            }
        }


        private void RemoveAllCars()
        {
            Vehicle[] allVehicles = World.GetAllVehicles();
            foreach (Vehicle vehicle in allVehicles)
            {
                if (vehicle.Driver != null && vehicle.Driver != Game.Player.Character) continue;
                vehicle.Delete();
            }
        }


        private void SpawnTestCar()
        {
            Vehicle testVehicle = World.GetClosestVehicle(Game.Player.Character.Position, 50f);
        }


        private int ChangeCars()
        {
            int count = 0;
            doing = false;
            Vehicle[] allVehicles = World.GetAllVehicles();
            foreach (Vehicle oldVehicle in allVehicles)
            {
                // Use this to detect if car was already changed or not
                if (oldVehicle.Mods.DashboardColor == VehicleColor.Chrome) continue;
                if (oldVehicle.Model.IsTrain) continue;
                if (Function.Call<bool>(Hash.IS_ENTITY_A_MISSION_ENTITY, oldVehicle))
                {
                    if (config.randomizeColor)
                    {
                        if (random.Next(3) == 0)
                        {
                            oldVehicle.Mods.PrimaryColor = allVehicleColors[random.Next(allVehicleColors.Length)];
                            oldVehicle.Mods.SecondaryColor = allVehicleColors[random.Next(allVehicleColors.Length)];
                            oldVehicle.Mods.PearlescentColor = allVehicleColors[random.Next(allVehicleColors.Length)];
                        }
                        else
                        {
                            oldVehicle.Mods.CustomPrimaryColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                            oldVehicle.Mods.CustomSecondaryColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                        }
                        if (random.Next(3) == 0) oldVehicle.Mods.RimColor = allVehicleColors[random.Next(allVehicleColors.Length)];
                    }

                    // Mod mission vehicles more often so it's actually noticeable
                    if (config.modVehicles && random.Next(100) < config.missionVehicleModChance) UpgradeVehicle(oldVehicle);

                    oldVehicle.Mods.DashboardColor = VehicleColor.Chrome;
                    continue;
                }

                Ped driver = oldVehicle.Driver;
                bool isCop = false;
                if (driver != null)
                {
                    // Don't do this for player's car
                    if (driver.IsPlayer) continue;

                    isCop = driver.IsInPoliceVehicle;
                    //driver.IsPersistent = true;
                    Function.Call(Hash.SET_ENTITY_AS_MISSION_ENTITY, driver, true, true);
                    driver.AlwaysKeepTask = false;
                }

                // Creates new vehicle
                Model newModel;
                if (config.specialClasses && oldVehicle.Model.IsBoat)
                {
                    newModel = new Model(availableBoats[random.Next(availableBoats.Count)]);
                }
                else if (config.specialClasses && oldVehicle.Model.IsHelicopter)
                {
                    newModel = new Model(availableHelis[random.Next(availableHelis.Count)]);
                }
                else if (config.specialClasses && oldVehicle.Model.IsPlane)
                {
                    newModel = new Model(availablePlanes[random.Next(availablePlanes.Count)]);
                }
                else
                {
                    newModel = new Model(availableVehicles[random.Next(availableVehicles.Count)]);
                }
                //File.AppendAllText("scripts//RandomVehicles.log ", newModel.GetHashCode().ToString() + "\n");
                newModel.Request();


                // This model stuff prevents game from crashing after a while
                if (newModel.IsInCdImage && newModel.IsValid)
                {
                    while (!newModel.IsLoaded) Script.Wait(10);
                }
                else
                {
                    //File.AppendAllText("scripts//RandomVehicles.log ", "unable to load (vehicle): " + newModel.ToString() + "\n");
                    gui.ShowNotification("Vehicle Model loading failed!");
                    return 0;
                }

                Vehicle newVehicle = World.CreateVehicle(newModel, oldVehicle.Position, oldVehicle.Heading);
                newModel.MarkAsNoLongerNeeded();
                //newVehicle.IsPersistent = false;

                if (config.randomizeColor)
                {
                    if (random.Next(3) == 0)
                    {
                        newVehicle.Mods.PrimaryColor = allVehicleColors[random.Next(allVehicleColors.Length)];
                        newVehicle.Mods.SecondaryColor = allVehicleColors[random.Next(allVehicleColors.Length)];
                        newVehicle.Mods.PearlescentColor = allVehicleColors[random.Next(allVehicleColors.Length)];
                    }
                    else
                    {
                        newVehicle.Mods.CustomPrimaryColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                        newVehicle.Mods.CustomSecondaryColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    }
                    if (random.Next(3) == 0) newVehicle.Mods.RimColor = allVehicleColors[random.Next(allVehicleColors.Length)];
                }


                // Makes the new vehicle move like the old one (no startup delay)
                newVehicle.ForwardSpeed = oldVehicle.Speed;
                newVehicle.Velocity = oldVehicle.Velocity;

                if (config.modVehicles && random.Next(100) < config.vehicleModChance) UpgradeVehicle(newVehicle);

                newVehicle.Mods.DashboardColor = VehicleColor.Chrome;

                oldVehicle.Delete();

                if (driver != null)
                {
                    newVehicle.IsEngineRunning = true;
                    driver.SetIntoVehicle(newVehicle, VehicleSeat.Driver);


                    if (isCop && Game.Player.WantedLevel > 0)
                    {
                        //Function.Call(Hash.SET_PED_KEEP_TASK, driver, true);
                        if (newVehicle.Model.IsHelicopter)
                        {

                            Function.Call(Hash.TASK_HELI_MISSION, driver, newVehicle, 0, Game.Player.Character, 0f, 0f, 0f, 4, 100f, 10f, (Game.Player.Character.Position - newVehicle.Position).ToHeading(), -1, -1, -1, 32); //0 instead of 32, 9 instead of 4
                            //Function.Call(Hash.SET_PED_KEEP_TASK, driver, true);
                            //driver.Task.VehicleChase(Game.Player.Character);
                            //Function.Call(Hash.TASK_HELI_CHASE, driver, Game.Player.Character.CurrentVehicle, 0f, 0f, 0f);
                            //Function.Call(Hash.TASK_COMBAT_PED, driver, Game.Player.Character, 0, 16);
                            Function.Call(Hash.SET_PED_KEEP_TASK, driver, true);
                        }
                        else
                        {
                            driver.Task.VehicleChase(Game.Player.Character);
                            //Function.Call(Hash.TASK_VEHICLE_CHASE, driver, Game.Player.Character);
                            Function.Call(Hash.SET_PED_KEEP_TASK, driver, true);
                        }
                    }
                    else
                    {
                        Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver, newVehicle, (float)config.aiDrivingSpeed, (int)DrivingStyle.Normal);
                        Function.Call(Hash.SET_PED_KEEP_TASK, driver, true);
                    }

                    driver.MarkAsNoLongerNeeded();
                }

                newVehicle.MarkAsNoLongerNeeded();
                count++;
            }

            doing = true;
            return count;
        }


        private int GiveRandomWeapons()
        {
            int count = 0;
            HashSet<int> newProcessedPeds = new HashSet<int>();

            Ped[] allPeds = World.GetAllPeds();
            foreach (Ped ped in allPeds)
            {
                // To make cops have random weapons (they are given weapons after they leave car
                // TODO it seemed that it would reset otherwise, or maybe not? - should test this again
                if (ped.IsInVehicle()) continue;

                newProcessedPeds.Add(ped.Handle);

                if (processedPeds.Contains(ped.Handle)) continue;
                if (!ped.IsAlive) continue;
                if (ped.IsPlayer) continue;

                // TODO maybe removing weapons should not be done - weapons removed from player?
                ped.Weapons.RemoveAll();
                WeaponHash randomWeaponHash = (WeaponHash)allWeapons[random.Next(allWeapons.Length)];
                ped.Weapons.Give(randomWeaponHash, 500, true, true);
                if (config.tintedWeapons) ped.Weapons.Current.Tint = allWeaponTints[random.Next(allWeaponTints.Length)];

                count++;
            }

            processedPeds = newProcessedPeds;
            return count;
        }


        private void UpgradeVehicle(Vehicle vehicle)
        {

            vehicle.Mods.InstallModKit();

            // Performance mods
            for (int i = 0; i < 17; i++)
            {
                // Set max upgrades
                if (config.maxModVehicles || random.Next(10) == 0) SetMod(vehicle, i, GetModCount(vehicle, i) - 1);
                // Set random upgrades
                else SetMod(vehicle, i, random.Next(GetModCount(vehicle, i)) - 1);

            }

            // Vanity mods
            for (int i = 23; i < 49; i++)
            {
                SetMod(vehicle, i, random.Next(GetModCount(vehicle, i)) - 1);
            }
        }


        private int GetModCount(Vehicle vehicle, int mod)
        {
            // This was removed from SHVDN v3
            return Function.Call<int>(Hash.GET_NUM_VEHICLE_MODS, vehicle.Handle, mod);
        }


        private void SetMod(Vehicle vehicle, int modType, int modIndex)
        {
            // This was removed from SHVDN v3
            Function.Call(Hash.SET_VEHICLE_MOD, vehicle.Handle, modType, modIndex, false);
        }

    }
}