namespace Iterator
{
    public class HandHeldInventoryIterator : IInventoryIterator
    {
        public HandHeldInventoryIterator(HandHeldInventory inventory)
        {
            this.Inventory = inventory;
        }

        public HandHeldInventory Inventory { get; }

        public Item GetCurrent()
        {
            switch (this.index)
            {
                case 0:
                    return this.Inventory.Right;

                case 1:
                    return this.Inventory.Left;

                default:
                    return null;
            }
        }

        private int index = 0;

        public bool IsDone()
        {
            return index < 2;
        }

        public void Next()
        {
            this.index += 1;
        }
    }
}