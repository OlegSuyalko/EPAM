using VehiclesClassSystem;
using VehiclesClassSystem.VehicleParts;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleFleet
{
    public class VehicleFleet
    {
        public List<Vehicle> Vehicles { get; set; }

        public VehicleFleet() { }

        public VehicleFleet(List<Vehicle> vehicles) => this.Vehicles = vehicles;

        public List<Vehicle> GetVehiclesWithEngineVolumeGreaterThan(double volumeLoverLimit)
        {
            if (Vehicles is null)
            {
                return new List<Vehicle>();
            }

            return (from vehicle in Vehicles
                    where vehicle.Engine.VolumeDmCubed > volumeLoverLimit
                    select vehicle).ToList();
        }
        public List<Engine> GetEnginesOfBussesAndTrucks()
        {
            if (Vehicles is null)
            {
                return new List<Engine>();
            }

            return (from vehicle in Vehicles
                    where vehicle is Bus || vehicle is Truck
                    select vehicle.Engine).ToList();
        }
        public List<Vehicle> GroupByTransmission()
        {
            if (Vehicles is null)
            {
                return new List<Vehicle>();
            }

            return (from vehicle in Vehicles
                    group vehicle by vehicle.Transmission.Type into groups
                    from _group in groups.ToList()
                    select _group).ToList();
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            foreach (Vehicle vehicle in Vehicles)
            {
                output.Append(vehicle.ToString() + "\n");
            }
            return output.ToString();
        }
    }
}