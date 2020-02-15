using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using System.Linq;

namespace RandomVehicles
{
    public class RandomVehicles : Script
    {

        private Random random = new Random();
        private long tick = 0;
        private bool keysActive = false;
        private bool doing = true;

        private List<VehicleHash> availableVehicles = new List<VehicleHash>();
        private List<VehicleHash> availableBoats = new List<VehicleHash>();
        private List<VehicleHash> availablePlanes = new List<VehicleHash>();
        private List<VehicleHash> availableHelis = new List<VehicleHash>();

        private uint[] allWeapons;
        private WeaponTint[] allWeaponTints;
        private VehicleColor[] allVehicleColors;

        int carsCount = 0;
        int weaponsCount = 0;

        private List<int> processedPeds = new List<int>();
        GUI gui = new GUI();
        Config config = new Config();

        /*private bool debugMode = true;
        private bool randomizeColor = true;
        private bool specialClasses = true;
        private bool trailers = false;
        private bool randomizeWeapons = true;
        private bool modVehicles = true;
        private bool maxModVehicles = false;
        private bool tintedWeapons = true;
        private int aiDrivingSpeed = 1000;
        private int vehicleModChance = 25;
        private int missionVehicleModChance = 50;*/

        public RandomVehicles()
        {
            Prepare();
            this.Tick += onTick;
            this.KeyUp += onKeyUp;
            this.KeyDown += onKeyDown;
        }

        private void onTick(object sender, EventArgs e)
        {
            if (doing) tick++;

            if (tick % 100 == 0)
            {
                carsCount = ChangeCars();
                if (config.randomizeWeapons) weaponsCount = GiveRandomWeapons();
            }

            if (config.debugMode) gui.Draw(carsCount + " Cars changed, " + weaponsCount + " Peds equipped", tick.ToString());
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


        private void Prepare()
        {
            bool errors = false;

            // Read setting from config and show errors if there are any
            List<string> configErrors = config.ReadConfig();
            int i = 0;
            foreach (string configError in configErrors)
            {
                if (configError == "") continue;
                i++;
                errors = true;
                GTA.UI.Notification.Show(i.ToString() + ": " + configError);
                /*GTA.UI.Screen.ShowSubtitle(i.ToString() + ": " + configError, 4900);
                Script.Wait(5000);*/
            }

            allWeapons = Weapons.getWeaponHashes();
            //allWeapons = Enum.GetValues(typeof(WeaponHash)).Cast<WeaponHash>().ToArray();
            allWeaponTints = Enum.GetValues(typeof(WeaponTint)).Cast<WeaponTint>().ToArray();
            allVehicleColors = Enum.GetValues(typeof(VehicleColor)).Cast<VehicleColor>().ToArray();

            // TODO clean this
            if (config.dlcVehicles)
            {
                availableVehicles.AddRange(VehicleClasses.missingHashes);
                availableVehicles.AddRange(VehicleClasses.motorbikes);
                availableVehicles.AddRange(VehicleClasses.bicycles);
                availableVehicles.AddRange(VehicleClasses.commercials);
                availableVehicles.AddRange(VehicleClasses.compacts);
                availableVehicles.AddRange(VehicleClasses.coupes);
                availableVehicles.AddRange(VehicleClasses.emergency);
                availableVehicles.AddRange(VehicleClasses.military);
                availableVehicles.AddRange(VehicleClasses.muscle);
                availableVehicles.AddRange(VehicleClasses.offroad);
                availableVehicles.AddRange(VehicleClasses.pickups);
                availableVehicles.AddRange(VehicleClasses.sedans);
                availableVehicles.AddRange(VehicleClasses.service);
                availableVehicles.AddRange(VehicleClasses.sports);
                availableVehicles.AddRange(VehicleClasses.sportsClassic);
                availableVehicles.AddRange(VehicleClasses.super);
                availableVehicles.AddRange(VehicleClasses.suvs);
                availableVehicles.AddRange(VehicleClasses.trucks);
                availableVehicles.AddRange(VehicleClasses.vans);

                if (config.trailers)
                {
                    availableVehicles.AddRange(VehicleClasses.trailers);
                }

                if (config.specialClasses)
                {
                    availableBoats.AddRange(VehicleClasses.boats);
                    availablePlanes.AddRange(VehicleClasses.planes);
                    availableHelis.AddRange(VehicleClasses.helicopters);
                }
                else
                {
                    availableVehicles.AddRange(VehicleClasses.boats);
                    availableVehicles.AddRange(VehicleClasses.planes);
                    availableVehicles.AddRange(VehicleClasses.helicopters);
                }
            }
            else
            {
                availableVehicles.AddRange(VehicleClassesVanilla.motorbikes);
                availableVehicles.AddRange(VehicleClassesVanilla.bicycles);
                availableVehicles.AddRange(VehicleClassesVanilla.commercials);
                availableVehicles.AddRange(VehicleClassesVanilla.compacts);
                availableVehicles.AddRange(VehicleClassesVanilla.coupes);
                availableVehicles.AddRange(VehicleClassesVanilla.emergency);
                availableVehicles.AddRange(VehicleClassesVanilla.military);
                availableVehicles.AddRange(VehicleClassesVanilla.muscle);
                availableVehicles.AddRange(VehicleClassesVanilla.offroad);
                availableVehicles.AddRange(VehicleClassesVanilla.pickups);
                availableVehicles.AddRange(VehicleClassesVanilla.sedans);
                availableVehicles.AddRange(VehicleClassesVanilla.service);
                availableVehicles.AddRange(VehicleClassesVanilla.sports);
                availableVehicles.AddRange(VehicleClassesVanilla.sportsClassic);
                availableVehicles.AddRange(VehicleClassesVanilla.super);
                availableVehicles.AddRange(VehicleClassesVanilla.suvs);
                availableVehicles.AddRange(VehicleClassesVanilla.trucks);
                availableVehicles.AddRange(VehicleClassesVanilla.vans);

                if (config.trailers)
                {
                    availableVehicles.AddRange(VehicleClassesVanilla.trailers);
                }

                if (config.specialClasses)
                {
                    availableBoats.AddRange(VehicleClassesVanilla.boats);
                    availablePlanes.AddRange(VehicleClassesVanilla.planes);
                    availableHelis.AddRange(VehicleClassesVanilla.helicopters);
                }
                else
                {
                    availableVehicles.AddRange(VehicleClassesVanilla.boats);
                    availableVehicles.AddRange(VehicleClassesVanilla.planes);
                    availableVehicles.AddRange(VehicleClassesVanilla.helicopters);
                }
            }

            GTA.UI.Screen.ShowSubtitle("RandomVehicles.dll initiated " + (errors ? "with errors" : "sucessfully"), 5000);
        }


        private void ActivateKeys(bool activate)
        {
            if (activate && !keysActive)
            {
                keysActive = true;
                GTA.UI.Screen.ShowSubtitle("Keys Activated", 4000);
            }
            else if (!activate && keysActive)
            {
                keysActive = false;
                GTA.UI.Screen.ShowSubtitle("Keys Deactivated", 4000);
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
                    GTA.UI.Screen.ShowSubtitle("Vehicle Model loading failed!", 4000);
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
            List<int> newProcessedPeds = new List<int>();

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