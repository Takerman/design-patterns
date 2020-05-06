using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takerman.DesignPatterns.AbstractFactory
{
    class ConcreteFactory2 : Factory
    {
        public override ProductA GetProductA()
        {
            return new ConcreteProductA2();
        }

        public override ProductB GetProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
