using System;

namespace VehiclesClassSystem.VehicleParts
{
    public class Transmission
    {
        public Transmission(string type, int numberOfGears, string manufacturer)
        {
            this.Type = type;
            this.NumberOfGears = numberOfGears;
            this.Manufacturer =  manufacturer;
        }

        public string Type { get; }

        public int NumberOfGears { get; }

        public string Manufacturer { get; }

        public override string ToString()
            => $"Type: {this.Type}; Number of gears: {this.NumberOfGears}; Manufacturer: {this.Manufacturer}.";
    }
}
