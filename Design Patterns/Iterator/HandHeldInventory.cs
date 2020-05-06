namespace Iterator
{
    public class HandHeldInventory : IInventory
    {
        public HandHeldInventory(Item right, Item left)
        {
            this.Right = right;
            this.Left = left;
        }

        public Item Right { get; private set; }

        public Item Left { get; private set; }

        public IInventoryIterator GetInventoryIterator()
        {
            return new HandHeldInventoryIterator(this);
        }
    }
}