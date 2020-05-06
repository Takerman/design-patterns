using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takerman.DesignPatterns.AbstractFactory
{
    class ConcreteFactory3 : Factory
    {
        public override ProductA GetProductA()
        {
            return new ConcreteProductA3();
        }

        public override ProductB GetProductB()
        {
            return new ConcreteProductB3();
        }
    }
}
