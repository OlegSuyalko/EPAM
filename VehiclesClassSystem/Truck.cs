using System;
using VehiclesClassSystem.VehicleParts;

namespace VehiclesClassSystem
{
    public class Truck : Vehicle
    {
        public Truck(Engine engine, RollingChassis rollingChassis, Transmission transmission, string cargoType)
        {
            this.Engine = engine;
            this.RollingChassis = rollingChassis;
            this.Transmission = transmission;
            this.CargoType = cargoType;
        }

        public string CargoType { get; }

        public override string ToString()
            => base.ToString() +
            "\nCargo type:" +
            $"\n{this.CargoType}.";
    }
}
