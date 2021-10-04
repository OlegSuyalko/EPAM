using System;
using VehiclesClassSystem.VehicleParts;

namespace VehiclesClassSystem
{
    [Serializable]
    public class Bus : Vehicle
    {
        public int PeopleCapacity { get; set; }
        public Bus() { }
        public Bus(Engine engine, RollingChassis rollingChassis, Transmission transmission, int peopleCapacity)
            : base(engine, rollingChassis, transmission) => this.PeopleCapacity = peopleCapacity;
        public override string ToString()
            => base.ToString() +
            "\nPeople capacity:" +
            $"\n{this.PeopleCapacity} people.";
    }
}
