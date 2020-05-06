using System;
using Takerman.DesignPatterns.FactoryPattern;

namespace Takerman.DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory animalFactory = new RandomAnimalFactory();


            for (int i = 0; i < 10; i++)
            {
                var animal = animalFactory.Create();
                Console.WriteLine("The " + animal.GetType().Name + " make " + animal.MakeSound());
            }

            Console.ReadKey();
        }
    }
}
