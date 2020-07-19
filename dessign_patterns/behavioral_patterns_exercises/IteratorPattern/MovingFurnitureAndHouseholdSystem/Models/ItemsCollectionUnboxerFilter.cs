using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MovingFurnitureAndHouseholdSystem.Models;

namespace MovingFurnitureAndHouseholdSystem.Models
{
    public class ItemsCollectionUnboxerFilter : IEnumerable<Item>
    {
        public List<Item> _items = new List<Item>();
        private string _nameOfEnumerator;
        public ItemsCollectionUnboxerFilter(List<Item> items, string nameOfEnumerator)
        {
            _items.AddRange(items);
            _nameOfEnumerator = nameOfEnumerator;
        }
        public IEnumerator<Item> GetEnumerator()
        {

            if (_nameOfEnumerator == "HeavyItemsUnboxerEnumerator")
            {
                Console.WriteLine("HeavyItemsUnboxerEnumerator branch:");
                return new HeavyItemsUnboxerEnumerator(this);
            }

            if (_nameOfEnumerator == "HeavyItemsUnboxerStackEnumerator")
            {
                Console.WriteLine("HeavyItemsUnboxerStackEnumerator branch:");
                return new HeavyItemsUnboxerStackEnumerator(this);
            }

            throw new NotSupportedException("Set an Enumerator");
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
