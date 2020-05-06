namespace Takerman.DotNetCore.StrategyPattern
{
    public class ModernFlying : IFlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("Modern Flying");
        }
    }
}