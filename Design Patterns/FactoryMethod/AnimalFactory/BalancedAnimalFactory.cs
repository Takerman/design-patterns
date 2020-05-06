using Takerman.DesignPatterns.FactoryPattern.Animals;

namespace Takerman.DesignPatterns.FactoryPattern
{
    public class BalancedAnimalFactory : IAnimalFactory
    {
        public IAnimal Create()
        {
            return new Cat();
        }
    }
}
