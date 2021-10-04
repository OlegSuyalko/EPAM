using System;

namespace Logic
{
    public struct Coordinate3D
    {
        public Coordinate3D(double x, double y, double z)
        {
            this.X = x >= 0 ? x : throw new ArgumentOutOfRangeException(nameof(x), $"{nameof(x)} must be non-negative");
            this.Y = y >= 0 ? y : throw new ArgumentOutOfRangeException(nameof(y), $"{nameof(y)} must be non-negative");
            this.Z = z >= 0 ? z : throw new ArgumentOutOfRangeException(nameof(z), $"{nameof(z)} must be non-negative");
        }

        public static double Distance(Coordinate3D c1, Coordinate3D c2)
            => Math.Sqrt(Math.Pow(c2.X - c1.X, 2) + Math.Pow(c2.Y - c1.Y, 2) + Math.Pow(c2.Z - c1.Z, 2));

        public double X { get; }

        public double Y { get; }

        public double Z { get; }
    }
}
