using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoMarsRover.Data
{
    public static class Extensions
    {
        public static bool IsPlaceOccupied(this Robot robot, int x, int y)
        {
            return x == robot.X && y == robot.Y;
        }

        public static void TurnLeft(this Robot robot)
        {
            if (Direction == Direction.N)
                Direction = Direction.W;
            else
            {
                Direction = ((Direction)((int)Direction) - 1);
            }
        }
    }
}
