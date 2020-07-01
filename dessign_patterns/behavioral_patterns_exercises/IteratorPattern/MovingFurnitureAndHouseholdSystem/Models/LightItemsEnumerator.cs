using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MovingFurnitureAndHouseholdSystem.Models
{
    public class LightItemsEnumerator : IEnumerator<Item>
    {

        private int indexOfItems = 0;
        private Item _CurrentItem { get; set; }

        private List<Item> _itemsCollection;
        public LightItemsEnumerator(ItemsCollectionFilter itemsCollection)
        {
            _itemsCollection = itemsCollection.GetFlatSubcollection();
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
            if (weigh < 30)
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
