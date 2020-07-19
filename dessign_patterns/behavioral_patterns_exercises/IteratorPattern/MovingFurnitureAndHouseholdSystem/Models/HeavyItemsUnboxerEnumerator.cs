using System;
using System.Collections;
using System.Collections.Generic;

namespace MovingFurnitureAndHouseholdSystem.Models
{
    internal class HeavyItemsUnboxerEnumerator : IEnumerator<Item>
    {
        private int indexOfItems = 0;
        private Item _CurrentItem { get; set; }

        private List<Item> _itemsCollectionToUnbox;

        public HeavyItemsUnboxerEnumerator(ItemsCollectionUnboxerFilter itemsCollection)
        {
            this._itemsCollectionToUnbox = itemsCollection._items;
        }

        public Item Current => _CurrentItem;

        object IEnumerator.Current => (object)Current;

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        public bool MoveNext()
        {
            if (indexOfItems == _itemsCollectionToUnbox.Count)
            {
                return false;
            }

            int weigh = 0;

            var cuurentItem = _itemsCollectionToUnbox[indexOfItems];

            weigh = cuurentItem.GetWeight();

            indexOfItems += 1;

            if (weigh < 30)
            {
                _CurrentItem = cuurentItem;
                return true;
            }
            else
            {
                _itemsCollectionToUnbox.AddRange(cuurentItem.SubCollection);
                return MoveNext();
            }
        }

        public void Reset()
        {
            indexOfItems = 0;
        }
    }
}