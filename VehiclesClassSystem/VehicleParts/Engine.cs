using System;

namespace VehiclesClassSystem.VehicleParts
{
    public class Engine
    {
        public Engine(string type, string serialNumber, double powerInHP, double volumeDmCubed)
        {
            this.PowerInHP = powerInHP;
            this.VolumeDmCubed = volumeDmCubed;
            this.Type = type;
            this.SerialNumber = serialNumber;
        }

        public string Type { get; }

        public string SerialNumber { get; }

        public double PowerInHP { get; }

        public double VolumeDmCubed { get; }

        public override string ToString()
            => $"Type: {this.Type}; Serial number: {this.SerialNumber}; Power: {this.PowerInHP} H.P.; Volume: {this.VolumeDmCubed} dm^3.";
    }
}
