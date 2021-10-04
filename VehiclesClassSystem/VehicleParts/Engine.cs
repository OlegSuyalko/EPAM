using System;

namespace VehiclesClassSystem.VehicleParts
{
    [Serializable]
    public class Engine
    {
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        public double PowerInHP { get; set; }
        public double VolumeDmCubed { get; set; }
        public Engine() { }
        public Engine(string type, string serialNumber, double powerInHP, double volumeDmCubed)
        {
            this.PowerInHP = powerInHP;
            this.VolumeDmCubed = volumeDmCubed;
            this.Type = type;
            this.SerialNumber = serialNumber;
        }
        public override string ToString()
            => $"Type: {this.Type}; Serial number: {this.SerialNumber}; Power: {this.PowerInHP} H.P.; Volume: {this.VolumeDmCubed} dm^3.";
    }
}
