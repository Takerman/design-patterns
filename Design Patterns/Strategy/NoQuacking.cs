namespace Takerman.DotNetCore.StrategyPattern
{
    public class NoQuacking : IQuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("");
        }
    }
}