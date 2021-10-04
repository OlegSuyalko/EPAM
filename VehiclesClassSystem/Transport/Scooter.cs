using System;
using VehiclesClassSystem.VehicleParts;

namespace VehiclesClassSystem
{
    [Serializable]
    public class Scooter : Vehicle
    {
        public bool DoesHaveSeat { get; set; }
        public Scooter() { }
        public Scooter(Engine engine, RollingChassis rollingChassis, Transmission transmission, bool doesHaveSeat)
        : base(engine, rollingChassis, transmission) => this.DoesHaveSeat = doesHaveSeat;
        public override string ToString()
            => base.ToString() +
            "\nDoes have a seat:" +
            $"\n{(this.DoesHaveSeat ? "yes" : "no")}.";
    }
}
