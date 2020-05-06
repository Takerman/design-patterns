namespace Takerman.DotNetCore.StrategyPattern
{
    public class CityDisplaying : IDisplayBehaviour
    {
        public void Display()
        {
            System.Console.WriteLine("City Displaying");
        }
    }
}