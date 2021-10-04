using System;

namespace VehiclesClassSystem.VehicleParts
{
    public class RollingChassis
    {
        public RollingChassis(int numberOfWheels, string number, int maxLoadKg)
        {
            this.NumberOfWheels = numberOfWheels;
            this.Number = number;
            this.MaxLoadKg = maxLoadKg;
        }

        public int NumberOfWheels { get; }

        public string Number { get; }

        public int MaxLoadKg { get; }

        public override string ToString()
            => $"NumberOfWheels: {this.NumberOfWheels}; Number: {this.Number}; Maximum load: {this.MaxLoadKg} kg.";
    }
}
