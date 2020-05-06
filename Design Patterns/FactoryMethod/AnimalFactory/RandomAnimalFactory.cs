using System;
using Takerman.DesignPatterns.FactoryPattern.Animals;

namespace Takerman.DesignPatterns.FactoryPattern
{
    public class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal Create()
        {
            var random = new Random();
            var index = random.Next(0, 3);

            switch (index)
            {
                case 0:
                    return new Cat();

                case 1:
                    return new Dog();

                case 2:
                    return new Duc();
            }

            return null;
        }
    }
}
