using System;

namespace VehiclesClassSystem.VehicleParts
{
    [Serializable]
    public class Transmission
    {
        public string Type { get; set; }
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
        public Transmission() { }
        public Transmission(string type, int numberOfGears, string manufacturer)
        {
            this.Type = type;
            this.NumberOfGears = numberOfGears;
            this.Manufacturer = manufacturer;
        }
        public override string ToString()
            => $"Type: {this.Type}; Number of gears: {this.NumberOfGears}; Manufacturer: {this.Manufacturer}.";
    }
}
