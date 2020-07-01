using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MovingFurnitureAndHouseholdSystem.Models;

namespace MovingFurnitureAndHouseholdSystem.Models
{
    public class ItemsCollectionFilter : IEnumerable<Item>
    {
        private bool _isHeavyMode;
        public List<Item> _items = new List<Item>();
        public ItemsCollectionFilter(List<Item> items, bool isHeavyMode)
        {
            _items.AddRange(items);
            _isHeavyMode = isHeavyMode;
        }
        public IEnumerator<Item> GetEnumerator()
        {
            if (_isHeavyMode)
            {

                Console.WriteLine("HeavyItemsEnumerator branch:");
                return new HeavyItemsEnumerator(this);
            }
            else
            {
                Console.WriteLine("LightItemsEnumerator branch:");

                return new LightItemsEnumerator(this);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<Item>)GetEnumerator();
        }

        public List<Item> GetFlatSubcollection()
        {
            List<Item> flatItems = new List<Item>();
            if (_items != null)
            {
                foreach (var item in _items)
                {
                    flatItems.AddRange(item.GetFlatSubcollection());
                }
            }


            return flatItems;
        }
    }
}
