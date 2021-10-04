using System;
using VehiclesClassSystem.VehicleParts;

namespace VehiclesClassSystem
{
    [Serializable]
    public class Car : Vehicle
    {
        public bool IsSportCar { get; set; }
        public Car() { }
        public Car(Engine engine, RollingChassis rollingChassis, Transmission transmission, bool isSportCar)
        : base(engine, rollingChassis, transmission) => this.IsSportCar = isSportCar;
        public override string ToString()
            => base.ToString() +
            "\nIs SportCar:" +
            $"\n{(this.IsSportCar ? "yes" : "no")}.";
    }
}
