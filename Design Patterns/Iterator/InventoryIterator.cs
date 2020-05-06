namespace Iterator
{
    public interface IInventoryIterator
    {
        bool IsDone();

        void Next();

        Item GetCurrent();
    }
}