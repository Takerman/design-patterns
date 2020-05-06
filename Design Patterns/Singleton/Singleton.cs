using System;

namespace Takerman.DesignPatterns.SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void Output()
        {
            Console.WriteLine("That's a method in the singleton");
        }
    }
}