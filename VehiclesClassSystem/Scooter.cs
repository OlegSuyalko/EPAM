using System;
using VehiclesClassSystem.VehicleParts;

namespace VehiclesClassSystem
{
    public class Scooter : Vehicle
    {
        public Scooter(Engine engine, RollingChassis rollingChassis, Transmission transmission, bool doesHaveSeat)
        {
            this.Engine = engine;
            this.RollingChassis = rollingChassis;
            this.Transmission = transmission;
            this.DoesHaveSeat = doesHaveSeat;
        }

        public bool DoesHaveSeat { get; }

        public override string ToString()
            => base.ToString() +
            "\nDoes have a seat:" +
            $"\n{(this.DoesHaveSeat ? "yes" : "no")}.";
    }
}
