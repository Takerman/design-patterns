using System;
using System.Collections.Generic;
using System.Text;

namespace Takerman.DesignPatterns.AdapterPattern
{
    public class Program
    {
        public static void Main(string [] args)
        {
            ITarget target = new Adapter(new Adaptee());
        }
    }
}
