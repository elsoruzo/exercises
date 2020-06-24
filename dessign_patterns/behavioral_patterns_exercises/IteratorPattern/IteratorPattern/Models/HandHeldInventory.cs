using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Models
{
    public class HandHeldInventory : Iinventory
    {
        public Item Right { get; private set; }
        public Item Left { get; private set; }

        public HandHeldInventory(Item left, Item right)
        {
            Right = right;
            Left = left;
        }
        public IinventoryIterator GetIterator()
        {
            return new HandHeldIiterator(this);
        }
    }
}
