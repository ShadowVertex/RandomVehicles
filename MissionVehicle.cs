using GTA;
using GTA.Native;

namespace RandomVehicles
{
    class MissionVehicle
    {
        // Pasting other vehicles on top of mission vehicles so that mission vehicles could be randomized?

        Vehicle baseVehicle;
        Vehicle overlayVehicle;

        public MissionVehicle(Vehicle baseVehicle, VehicleHash overlayVehicleHash)
        {
            this.baseVehicle = baseVehicle;
            this.baseVehicle.IsPersistent = true; // For testing only

            overlayVehicle = World.CreateVehicle(overlayVehicleHash, baseVehicle.Position, baseVehicle.Heading);
            overlayVehicle.IsPersistent = true;

            overlayVehicle.AttachTo(baseVehicle);
            overlayVehicle.IsCollisionEnabled = true;
            //overlayVehicle.SetNoCollision(baseVehicle, false);

            this.baseVehicle.IsVisible = false;
            overlayVehicle.IsVisible = true;


            baseVehicle.MaxSpeed = Function.Call<float>((Hash)0x53AF99BAA671CA47, overlayVehicle);
        }


        public bool Update(Vehicle playerCurrentVehicle)
        {
            if (!baseVehicle.Exists() || baseVehicle == null)
            {
                overlayVehicle.Delete();
                return false;
            }

            if (playerCurrentVehicle != null && playerCurrentVehicle == overlayVehicle)
            {
                Game.Player.Character.SetIntoVehicle(baseVehicle, VehicleSeat.Driver);
            }

            overlayVehicle.SteeringAngle = (float)(baseVehicle.SteeringAngle / (180.0 / System.Math.PI));
            overlayVehicle.ForwardSpeed = baseVehicle.Speed;

            return true;
        }
    }
}
