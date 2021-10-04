using Logic;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird(1, 2, 3);
            Console.WriteLine(bird.GetFlyTime(new Coordinate3D(2, 3, 4)));
            Plane plane = new Plane(1, 2, 3);
            Console.WriteLine(plane.GetFlyTime(new Coordinate3D(100, 200, 300)));
            Drone drone = new Drone(1, 2, 3);
            Console.WriteLine(drone.GetFlyTime(new Coordinate3D(100, 200, 300)));
        }
    }
}
