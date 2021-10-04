using System;
using VehiclesClassSystem;
using VehiclesClassSystem.VehicleParts;


namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine[] engines = new Engine[]
            {
                new Engine("Gas", "2687", 1560, 50),
                new Engine("DT", "1734", 1820, 40),
                new Engine("Gas", "7953", 2500, 70),
                new Engine("DT", "4781", 1950, 40),
            };

            RollingChassis[] rollingChasses = new RollingChassis[]
            {
                new RollingChassis(4, "4678", 2_000),
                new RollingChassis(12, "2348", 10_000),
                new RollingChassis(8, "9634", 20_000),
                new RollingChassis(2, "7541", 1_000),
            };

            Transmission[] transmissions = new Transmission[]
            {
                new Transmission("Automatic", 4, "Germany"),
                new Transmission("Manual", 6, "Russia"),
                new Transmission("Manual", 6, "China"),
                new Transmission("Automatic", 4, "Russia"),
            };

            Car car = new Car(engines[0], rollingChasses[0], transmissions[0], false);
            Console.WriteLine($"----------\nCar:\n----------\n{car}");
            Truck truck = new Truck(engines[1], rollingChasses[1], transmissions[1], "Furnitura");
            Console.WriteLine($"----------\nTruck:\n----------\n{truck}");
            Bus bus = new Bus(engines[2], rollingChasses[2], transmissions[2], 40);
            Console.WriteLine($"----------\nBus:\n----------\n{bus}");
            Scooter scooter = new Scooter(engines[3], rollingChasses[3], transmissions[3], true);
            Console.WriteLine($"----------\nScooter:\n----------\n{scooter}");
        }
    }
}
