using System;
using System.Collections.Generic;
using System.IO;

namespace RandomVehicles
{
    class Config
    {
        public bool dlcVehicles = true;
        public int aiDrivingSpeed = 1000;
        public bool randomizeColor = true;
        public bool specialClasses = true;
        public bool trailers = false;
        public bool modVehicles = true;
        public int vehicleModChance = 25;
        public int missionVehicleModChance = 50;
        public bool maxModVehicles = false;
        public bool randomizeWeapons = true;
        public bool tintedWeapons = true;
        public bool debugMode = false;


        public Config() { }


        private string WriteConfig()
        {
            StreamWriter writer;
            try
            {
                writer = new StreamWriter("scripts//RandomVehicles.ini");
            }
            catch (Exception)
            {
                return "Failed to write config file!";
            }


            writer.Write(String.Join(Environment.NewLine,
                "[vehicles]",
                "",
                "; If false then DLC vehicles that normally despawn instantly are not used. Install \"Add-On Vehicle Spawner\" for them to not despawn!",
                "; default: true",
                "dlcVehicles=true",
                "",
                "; How fast the AI drivers will drive (max speed). Normal speed is maybe like 40? ",
                "; default: 1000",
                "aiDrivingSpeed=1000",
                "",
                "; If true then all vehicles will have random colors",
                "; default: true",
                "randomizeColor=true",
                "",
                "; If true then boats, planes and helicopters will not spawn in traffic and will only be replaced by random vehicles from their own class",
                "; default: true",
                "specialClasses=true",
                "",
                "; If true then vehicles can be replaced by trailers",
                "; default: false",
                "trailers=false",
                "",
                "; If true then some vehicles will be upgraded with random vehicle mods",
                "; default: true",
                "modVehicles=true",
                "",
                "; The % chance that a vehicle will be upgraded with random vehicle mods",
                "; default: 25",
                "vehicleModChance=25",
                "",
                "; The % chance that a mission vehicle will be upgraded with random vehicle mods ",
                "; default: 50",
                "missionVehicleModChance=50",
                "",
                ";  If true then all vehicles that are upgraded will recieve the best modifications available, if false then random modifications",
                "; default: false",
                "maxModVehicles=false",
                "",
                "[weapons]",
                "",
                "; If true then every ped will be given a random weapon",
                "; default: true",
                "randomizeWeapons=true",
                "",
                "; If true then weapons will have a random color (tint)",
                "; default: true",
                "tintedWeapons=true",
                "",
                "[debug]",
                "",
                "; Show debug text and activate debug buttons (pageup + numpad keys)",
                "; default: false",
                "debugMode=false"));

            writer.Flush();
            writer.Close();
            return "";
        }


        public List<string> ReadConfig()
        {
            List<string> errors = new List<string>();

            StreamReader reader;
            try
            {
                reader = new StreamReader("scripts//RandomVehicles.ini");
            }
            catch (Exception)
            {
                errors.Add("Couldn't find \"RandomVehicles.ini\" config file. Creating new config file");
                errors.Add(WriteConfig());
                return errors;
            }

            // Reading all lines from config file
            string line = reader.ReadLine();
            while (line != null)
            {
                string result = ProcessConfigLine(line);

                if (result != "")
                {
                    if (result.StartsWith("-"))
                    {
                        errors.Add("Unable to understand line that starts with " + result);
                    }
                    else
                    {
                        errors.Add("Unable to parse parameter " + result + ". Using default value instead.");
                    }
                }

                line = reader.ReadLine();
            }

            reader.Close();

            if (errors.Count > 0) errors.Add("Hint, you can delete the config file and a new, properly working one will be created");
            return errors;
        }


        private string ProcessConfigLine(string line)
        {
            if (line.Length == 0) return "";
            if (line.StartsWith(";") || line.StartsWith("[") || line.StartsWith("#")) return "";

            string[] vals = line.Split('=');

            switch (vals[0])
            {
                case "dlcVehicles":
                    if (!bool.TryParse(vals[1], out dlcVehicles))
                    {
                        dlcVehicles = true;
                        return vals[0];
                    }
                    break;
                case "aiDrivingSpeed":
                    if (!int.TryParse(vals[1], out aiDrivingSpeed))
                    {
                        aiDrivingSpeed = 1000;
                        return vals[0];
                    }
                    break;
                case "randomizeColor":
                    if (!bool.TryParse(vals[1], out randomizeColor))
                    {
                        randomizeColor = true;
                        return vals[0];
                    }
                    break;
                case "specialClasses":
                    if (!bool.TryParse(vals[1], out specialClasses))
                    {
                        specialClasses = true;
                        return vals[0];
                    }
                    break;
                case "trailers":
                    if (!bool.TryParse(vals[1], out trailers))
                    {
                        trailers = false;
                        return vals[0];
                    }
                    break;
                case "modVehicles":
                    if (!bool.TryParse(vals[1], out modVehicles))
                    {
                        modVehicles = true;
                        return vals[0];
                    }
                    break;
                case "vehicleModChance":
                    if (!int.TryParse(vals[1], out vehicleModChance))
                    {
                        vehicleModChance = 25;
                        return vals[0];
                    }
                    break;
                case "missionVehicleModChance":
                    if (!int.TryParse(vals[1], out missionVehicleModChance))
                    {
                        missionVehicleModChance = 50;
                        return vals[0];
                    }
                    break;
                case "maxModVehicles":
                    if (!bool.TryParse(vals[1], out maxModVehicles))
                    {
                        maxModVehicles = false;
                        return vals[0];
                    }
                    break;
                case "randomizeWeapons":
                    if (!bool.TryParse(vals[1], out randomizeWeapons))
                    {
                        randomizeWeapons = true;
                        return vals[0];
                    }
                    break;
                case "tintedWeapons":
                    if (!bool.TryParse(vals[1], out tintedWeapons))
                    {
                        tintedWeapons = true;
                        return vals[0];
                    }
                    break;
                case "debugMode":
                    if (!bool.TryParse(vals[1], out debugMode))
                    {
                        debugMode = false;
                        return vals[0];
                    }
                    break;
                default:
                    return "- " + vals[0];
            }

            return "";
        }


    }
}
