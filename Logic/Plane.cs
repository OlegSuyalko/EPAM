namespace Logic
{
    public class Plane : IFlyable
    {
        public Plane(int x, int y, int z)
        {
            this.CurrentCoordinate = new Coordinate3D(x, y, z);
        }

        public void FlyTo(Coordinate3D newCoordinate)
        {
            this.CurrentCoordinate = newCoordinate;
        }

        /// <summary>
        /// Calculates the time in hours needed for flying to a new coordinate.
        /// Plane has initial velocity 200 km/h and instantly increases it every 10 kilometers.
        /// </summary>
        /// <param name="newCoordinate">Coordinate for flight to which time is calculated.</param>
        /// <returns>Time of flight.</returns>
        public double GetFlyTime(Coordinate3D newCoordinate)
        {
            double distance = Coordinate3D.Distance(this.CurrentCoordinate, newCoordinate);
            double time = 0;
            int velocity = 200;
            const int deltaVelocity = 10;
            const int deltaDistance = 10;
            for (int i = 0; i < distance; i += deltaDistance, velocity += deltaVelocity)
            {
                time += distance / velocity;
            }

            return time;
        }

        public Coordinate3D CurrentCoordinate { get; set; }
    }
}
