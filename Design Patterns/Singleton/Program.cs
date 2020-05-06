using System;

namespace Takerman.DesignPatterns.SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = Singleton.GetInstance();
            instance.Output();

            Console.ReadKey();
        }
    }
}
