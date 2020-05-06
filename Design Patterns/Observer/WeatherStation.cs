using System.Collections.Generic;

namespace Takerman.DesignPatterns.ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private readonly List<IObserver> observables;

        public int Temperature { get; set; }

        public WeatherStation()
        {
            observables = new List<IObserver>();
        }

        public void Add(IObserver observer)
        {
            observables.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in observables)
            {
                observer.Update();
            }
        }

        public int GetTemperature()
        {
            return Temperature;
        }

        public void Remove(IObserver observer)
        {
            observables.Remove(observer);
        }
    }
}