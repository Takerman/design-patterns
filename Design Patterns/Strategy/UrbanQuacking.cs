namespace Takerman.DotNetCore.StrategyPattern
{
    public class UrbanQuacking : IQuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("Urban Quack");
        }
    }
}