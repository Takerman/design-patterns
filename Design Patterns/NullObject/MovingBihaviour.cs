using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    public class MovingBihaviour : IMovingBihaviour
    {
        public void GoDown()
        {
            Console.WriteLine("The player went down");
        }

        public void GoLeft()
        {
            Console.WriteLine("The player went left");
        }

        public void GoRight()
        {
            Console.WriteLine("The player went right");
        }

        public void GoUp()
        {
            Console.WriteLine("The player went up");
        }
    }
}
