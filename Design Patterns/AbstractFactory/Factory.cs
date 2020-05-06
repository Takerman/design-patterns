using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takerman.DesignPatterns.AbstractFactory
{
    public abstract class Factory
    {
        public abstract ProductA GetProductA();
        public abstract ProductB GetProductB();
    }
}
