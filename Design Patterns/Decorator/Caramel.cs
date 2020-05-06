namespace Takerman.DesignPatterns.DecoratorPattern
{
    public class Caramel : AddonDecorator
    {
        private Beverage beverage;

        public Caramel(Beverage b)
        {
            beverage = b;
        }

        public override int Cost()
        {
            return beverage.Cost() + 2;
        }
    }
}
