using System;
using VehiclesClassSystem.VehicleParts;

namespace VehiclesClassSystem
{
    [Serializable]
    public class Truck : Vehicle
    {
        public string CargoType { get; set; }
        public Truck() { }
        public Truck(Engine engine, RollingChassis rollingChassis, Transmission transmission, string cargoType)
        : base(engine, rollingChassis, transmission) => this.CargoType = cargoType;
        public override string ToString()
            => base.ToString() +
            "\nCargo type:" +
            $"\n{this.CargoType}.";
    }
}
