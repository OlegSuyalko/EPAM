using System;
using VehiclesClassSystem.VehicleParts;
using System.Xml.Serialization;

namespace VehiclesClassSystem
{
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Scooter))]
    [XmlInclude(typeof(Truck))]
    [Serializable]
    public abstract class Vehicle
    {
        public Engine Engine { get; set; }
        public RollingChassis RollingChassis { get; set; }
        public Transmission Transmission { get; set; }
        public Vehicle() { }
        public Vehicle(Engine engine, RollingChassis rollingChassis, Transmission transmission)
        {
            this.Engine = engine;
            this.RollingChassis = rollingChassis;
            this.Transmission = transmission;
        }
        public override string ToString()
        {
            return "Engine info" +
                $"\n{this.Engine}" +
                "\nRolling chassis info:" +
                $"\n{this.RollingChassis}" +
                "\nTransmission info:" +
                $"\n{this.Transmission}";
        }
    }
}
