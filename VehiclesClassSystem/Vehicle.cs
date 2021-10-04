using System;
using VehiclesClassSystem.VehicleParts;

namespace VehiclesClassSystem
{
    public abstract class Vehicle
    {
        private Engine engine;
        private RollingChassis rollingChassis;
        private Transmission transmission;
        
        public Engine Engine
        {
            get => this.engine;
            set => this.engine = value;
        }

        public RollingChassis RollingChassis
        {
            get => this.rollingChassis;
            set => this.rollingChassis = value;
        }

        public Transmission Transmission
        {
            get => this.transmission;
            set => this.transmission = value;
        }

        public override string ToString()
        {
            return "Engine info:" +
                $"\n{this.Engine}" +
                "\nRolling chassis info:" +
                $"\n{this.RollingChassis}" +
                "\nTransmission info:" +
                $"\n{this.Transmission}";
        }
    }
}
