using System;
using VehiclesClassSystem.VehicleParts;

namespace VehiclesClassSystem
{
    public class Car : Vehicle
    {
        public Car(Engine engine, RollingChassis rollingChassis, Transmission transmission, bool isSportCar)
        {
            this.Engine = engine;
            this.RollingChassis = rollingChassis;
            this.Transmission = transmission;
            this.IsSportcar = isSportCar;
        }

        public bool IsSportcar { get; }

        public override string ToString()
            => base.ToString() +
            "\nIs sportcar:" +
            $"\n{(this.IsSportcar ? "yes" : "no")}.";
    }
}
