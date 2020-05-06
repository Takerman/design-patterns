namespace Takerman.DesignPatterns.DecoratorPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var espresso = new Espresso();
            var carameledEspresso = new Caramel(espresso);
        }
    }
}
