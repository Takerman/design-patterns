using System;

namespace Takerman.DesignPatterns.FactoryPattern.Animals
{
    public class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "Meow!";
        }
    }
}
