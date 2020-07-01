using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BoxesIterator.Models
{
    public class Inspector
    {
        private int level;
        private List<Box> _currentBoxCollection = new List<Box>();
        private Box _currentBox { get; set; }

        public List<Item> FlatItemCollection = new List<Item>();
        private Box _box { get; set; }
        public Inspector(Box box)
        {
            _currentBox = box;
            //_currentBoxCollection = box.BoxCollection;
        }

        public void GetAllItems()
        {
            do
            {
                var enumerator = _currentBox.GetEnumerator();
                foreach (var subBox in _currentBox.BoxCollection)
                {
                    if (subBox.BoxCollection != null)
                    {
                        _currentBoxCollection.AddRange(subBox.BoxCollection);
                    }
                }

                _currentBox = _currentBoxCollection[0];
                _currentBoxCollection.RemoveAt(0);

                FlatItemCollection.AddRange(GetFlatteAllItems(enumerator));
            } while (_currentBox.BoxCollection != null);
        }

        private List<Item> GetFlatteAllItems(IEnumerator<Item> enumerator)
        {
            List<Item> itemCollection = new List<Item>();
            while (enumerator.MoveNext())
            {
                itemCollection.Add(enumerator.Current);
            }

            return itemCollection;
        }
    }
}
