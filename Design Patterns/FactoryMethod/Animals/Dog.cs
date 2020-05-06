using System;

namespace Takerman.DesignPatterns.FactoryPattern.Animals
{
    public class Dog : IAnimal
    {
        public string MakeSound()
        {
            return "Bark!";
        }
    }
}
