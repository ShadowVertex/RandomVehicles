using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.UI;

namespace RandomVehicles
{
    class VehicleLoader
    {

        public static List<List<VehicleHash>> LoadFromFile(string path, bool specialClasses, bool useTrailers)
        {
            List<List<VehicleHash>> loadedVehicles = new List<List<VehicleHash>>();
            List<VehicleHash> loadedCars = new List<VehicleHash>();
            List<VehicleHash> loadedBoats = new List<VehicleHash>();
            List<VehicleHash> loadedPlanes = new List<VehicleHash>();
            List<VehicleHash> loadedHelis = new List<VehicleHash>();

            List<VehicleHash> current = loadedCars;
            bool inserting = false;

            // Initialize StreamReader
            StreamReader reader;
            try
            {
                reader = new StreamReader(path);
            }
            catch (Exception)
            {
                Notification.Show("Unable to locate " + path + " file!");
                return loadedVehicles; // empty
            }

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                // Ignore empty lines
                if (line.Length == 0) continue;

                // Select category
                if (line.StartsWith("["))
                {
                    switch (line)
                    {
                        case "[LAND VEHICLES]":
                            inserting = true;
                            current = loadedCars;
                            break;
                        case "[BOATS]":
                            inserting = true;
                            current = specialClasses ? loadedBoats : loadedCars;
                            break;
                        case "[PLANES]":
                            inserting = true;
                            current = specialClasses ? loadedPlanes : loadedCars;
                            break;
                        case "[HELICOPTERS]":
                            inserting = true;
                            current = specialClasses ? loadedHelis : loadedCars;
                            break;
                        case "[TRAILERS]":
                            inserting = useTrailers;
                            current = loadedCars;
                            break;
                        default:
                            Notification.Show("Category " + line + "not valid!");
                            inserting = false;
                            break;
                    }
                    continue;
                }

                Model convert = new Model(line);
                if (convert.IsValid && convert.IsInCdImage)
                {
                    if (inserting) current.Add((VehicleHash)convert.Hash);
                }
                else
                {
                    Notification.Show("Wrong model: " + line);
                }
                convert.MarkAsNoLongerNeeded();
            }

            reader.Close();

            loadedVehicles.Add(loadedCars);
            loadedVehicles.Add(loadedBoats);
            loadedVehicles.Add(loadedPlanes);
            loadedVehicles.Add(loadedHelis);
            return loadedVehicles;
        }



        public static void SaveToFile(string path, List<VehicleHash> vehicles)
        {
            // Initialize StreamWriter
            StreamWriter writer;
            try
            {
                writer = new StreamWriter(path, false);
            }
            catch (Exception)
            {
                Notification.Show("Unable to locate " + path + " file!");
                return;
            }

            foreach (VehicleHash vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }

            writer.Close();
        }


    }
}
