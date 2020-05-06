namespace Takerman.DotNetCore.StrategyPattern
{
    public class CityFlying : IFlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("City Flying");
        }
    }
}