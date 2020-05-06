namespace Takerman.DesignPatterns.ObserverPattern
{
    public interface IObservable
    {
        void Add(IObserver observer);

        void Remove(IObserver observer);

        void Notify();
    }
}
