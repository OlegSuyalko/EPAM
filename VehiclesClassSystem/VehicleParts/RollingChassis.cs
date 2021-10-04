using System;

namespace VehiclesClassSystem.VehicleParts
{
    [Serializable]
    public class RollingChassis
    {
        public int NumberOfWheels { get; set; }
        public string Number { get; set; }
        public int MaxLoadKg { get; set; }
        public RollingChassis() { }
        public RollingChassis(int numberOfWheels, string number, int maxLoadKg)
        {
            this.NumberOfWheels = numberOfWheels;
            this.Number = number;
            this.MaxLoadKg = maxLoadKg;
        }
        public override string ToString()
            => $"NumberOfWheels: {this.NumberOfWheels}; Number: {this.Number}; Maximum load: {this.MaxLoadKg} kg.";
    }
}
