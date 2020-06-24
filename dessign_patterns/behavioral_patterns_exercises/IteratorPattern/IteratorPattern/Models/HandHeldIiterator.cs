namespace IteratorPattern.Models
{
    public class HandHeldIiterator : IinventoryIterator
    {
        private HandHeldInventory _inventory;

        private int _index = 0;

        public HandHeldIiterator(HandHeldInventory inventory)
        {
            _inventory = inventory;
        }

        public Item GetCurrent()
        {
            switch (this._index)
            {
                case 0: return this._inventory.Right;
                case 1: return this._inventory.Left;
                default: return null;

            }
        }

        public void GoNext()
        {
            this._index += 1;
        }

        public bool IsDone()
        {
            return this._index < 2;
        }
    }
}
