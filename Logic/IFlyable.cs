using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    /// <summary>
    /// Represents object, which is capable of flying.
    /// Coordinates are measured in kilometers.
    /// </summary>
    public interface IFlyable
    {
        public void FlyTo(Coordinate3D newCoordinate);

        public double GetFlyTime(Coordinate3D newCoordinate);
    }
}
