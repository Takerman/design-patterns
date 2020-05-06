using System;

namespace Takerman.DotNetCore.StrategyPattern
{
    public class Program
    {
        // https://www.youtube.com/watch?v=v9ejT8FO-7I&t=14s&index=4&list=PLbJoT-7dZ2g4a8u_892FR1G2BY4FYMSI1
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern:");
            Console.WriteLine("................................");

            var cloudDuck = new Duck(new CloudDisplaying(), new CityFlying(), new NoQuacking());
            Console.WriteLine("Cloud Duck:");
            cloudDuck.Display();
            cloudDuck.Fly();
            cloudDuck.Quack();
            Console.WriteLine(Environment.NewLine);


            var cityDuck = new Duck(new CityDisplaying(), new ModernFlying(), new UrbanQuacking());
            Console.WriteLine("City Duck:");
            cityDuck.Display();
            cityDuck.Fly();
            cityDuck.Quack();
        }
    }
}
