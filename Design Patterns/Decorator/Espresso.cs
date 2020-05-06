using System;
using System.Collections.Generic;
using System.Text;

namespace Takerman.DesignPatterns.DecoratorPattern
{
    public class Espresso : Beverage
    {
        public override int Cost()
        {
            return 1;
        }
    }
}
