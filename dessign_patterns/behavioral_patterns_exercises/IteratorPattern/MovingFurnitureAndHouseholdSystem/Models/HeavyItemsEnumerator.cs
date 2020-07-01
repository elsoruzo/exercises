using System;
using System.Collections;
using System.Collections.Generic;

namespace MovingFurnitureAndHouseholdSystem.Models
{
    internal class HeavyItemsEnumerator : IEnumerator<Item>
    {
        private int indexOfItems = 0;
        private Item _CurrentItem { get; set; }

        private List<Item> _itemsCollection;

        public HeavyItemsEnumerator(ItemsCollectionFilter itemsCollection)
        {
            this._itemsCollection = itemsCollection.GetFlatSubcollection();
        }

        public Item Current => _CurrentItem;

        object IEnumerator.Current => (object)Current;

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        public bool MoveNext()
        {
            if (indexOfItems == _itemsCollection.Count)
            {
                return false;
            }

            int weigh = 0;

            var cuurentItem = _itemsCollection[indexOfItems];

            weigh = cuurentItem.GetWeight();

            indexOfItems += 1;

            if (weigh > 30)
            {
                _CurrentItem = cuurentItem;
                return true;
            }
            else
            {
                return MoveNext();
            }
        }

        public void Reset()
        {
            indexOfItems = 0;
        }
    }
}