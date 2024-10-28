using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoMarsRover.Data
{
    public sealed class Robot
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Direction Direction { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", X, Y, Direction);
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    if (!(obj is Robot)) return false;

        //    return X == ((Robot) obj).X && Y == ((Robot) obj).Y;
        //}

       
    }

    public enum Direction
    {
        N,
        E,
        S,
        W
    }

    public class Movement
    {
        public MoveAction MoveAction { get; private set; }
        public Func<int, int, Direction> MakeMove { get; private set; }


        public Movement(MoveAction moveAction, Func<int, int, Direction> actionForMove)
        {
            MoveAction = moveAction;
            MakeMove = actionForMove;
        }
    }

    public class TurnLeft : Movement
    {
        public TurnLeft() : base(MoveAction.L, ((x,y,d)=>(x,y,--d)))
        {
            throw new NotImplementedException();
        }
    {
        
    }
    }

    private Move

    public enum MoveAction
    {
        L,
        R,
        M
    }
}
