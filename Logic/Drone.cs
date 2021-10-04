namespace Logic
{
    public class Drone : IFlyable
    {
        public const int Velocity = 15;

        public Drone(int x, int y, int z)
        {
            this.CurrentCoordinate = new Coordinate3D(x, y, z);
        }

        public void FlyTo(Coordinate3D newCoordinate)
        {
            this.CurrentCoordinate = newCoordinate;
        }

        /// <summary>
        /// Calculates the time in hours needed for flying to a new coordinate.
        /// Drone has constant velocity equal to 15 and stops every 10 minutes of floght for 1 minute.
        /// </summary>
        /// <param name="newCoordinate">Coordinate for flight to which time is calculated.</param>
        /// <returns>Time of flight.</returns>
        public double GetFlyTime(Coordinate3D newCoordinate)
        {
            double distance = Coordinate3D.Distance(this.CurrentCoordinate, newCoordinate);
            double time = distance / Velocity;
            const int deltaTime = 10;
            const int additionalTime = 1;
            time -= (int)(time / deltaTime) * additionalTime;
            return time;
        }

        public Coordinate3D CurrentCoordinate { get; set; }
    }
}
