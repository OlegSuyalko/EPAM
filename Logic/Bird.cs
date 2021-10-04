using System;

namespace Logic
{
    public class Bird : IFlyable
    {
        public Bird(int x, int y, int z)
        {
            this.CurrentCoordinate = new Coordinate3D(x, y, z);
        }

        public void FlyTo(Coordinate3D newCoordinate)
        {
            this.CurrentCoordinate = newCoordinate;
        }

        /// <summary>
        /// Calculates the time in hours needed for flying to a new coordinate.
        /// Bird has randomly generated velocity between 1 and 20 inclusive.
        /// </summary>
        /// <param name="newCoordinate">Coordinate for flight to which time is calculated.</param>
        /// <returns>Time of flight.</returns>
        public double GetFlyTime(Coordinate3D newCoordinate)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            int velocity = random.Next(1, 21);
            return Coordinate3D.Distance(this.CurrentCoordinate, newCoordinate) / velocity;
        }

        public Coordinate3D CurrentCoordinate { get; set; }
    }
}
