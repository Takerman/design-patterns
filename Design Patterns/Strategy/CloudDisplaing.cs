namespace Takerman.DotNetCore.StrategyPattern
{
    public class CloudDisplaying : IDisplayBehaviour
    {
        public void Display()
        {
            System.Console.WriteLine("Cloud Displaying");
        }
    }
}