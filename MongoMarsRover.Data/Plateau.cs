using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoMarsRover.Data
{
    public sealed class Plateau
    {
        private static Plateau _instance;

        private Plateau()
        {
            _robots = new List<Robot>();
        }

        public static Plateau Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Plateau();
                }
                return _instance;
            }
        }

        public void Initialize(int x, int y)
        {
            if (_isInitialized) return;
            
            if (x < 0) throw new ArgumentException("bad value for x size of plateau", "x");
            if (y < 0) throw new ArgumentException("bad value for y size of plateau", "y");

            _xLimit = x;
            _yLimit = y;
            _isInitialized = true;
        }

        private readonly IList<Robot> _robots;
        private int _xLimit = -1;
        private int _yLimit = -1;

        private bool _isInitialized = false;

        public void AddRobot(Robot newRobot)
        {
            if (!_isInitialized) throw new ApplicationException("Plateau coordinates weren't initialized");

            if(_robots.Any(r=>r.IsPlaceOccupied(newRobot.X, newRobot.Y)))
                throw new ArgumentException("Robot is set to not vacant place", "newRobot");

            _robots.Add(newRobot);
        }

        public override string ToString()
        {
            string.Join(Environment.NewLine, _robots);
        }
    }
}
