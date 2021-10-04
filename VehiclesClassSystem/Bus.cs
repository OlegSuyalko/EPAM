using System;
using VehiclesClassSystem.VehicleParts;

namespace VehiclesClassSystem
{
    public class Bus : Vehicle
    {
        public Bus(Engine engine, RollingChassis rollingChassis, Transmission transmission, int peopleCapacity)
        {
            this.Engine = engine;
            this.RollingChassis = rollingChassis;
            this.Transmission = transmission;
            this.PeopleCapacity = peopleCapacity;
        }

        public int PeopleCapacity { get; }

        public override string ToString()
            => base.ToString() +
            "\nPeople capacity:" +
            $"\n{this.PeopleCapacity} people.";
    }
}
