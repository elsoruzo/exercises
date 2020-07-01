using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BoxesIterator.Models
{
    public class BoxEnumerator : IEnumerator<Item>
    {
        private int indexOfBoxes = 0;
        private int indexOfItems = 0;
        private ItemEnumerator _currentItemEnumerator { get; set; }
        private Item _CurrentItem { get; set; }
        private Box _CurrentBox;
        private Box _box;
        public BoxEnumerator(Box box)
        {
            _box = box;
        }

        public Item Current => _CurrentItem;

        object IEnumerator.Current => (object)Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (indexOfBoxes == 0 && indexOfItems == 0)
            {
                _currentItemEnumerator = new ItemEnumerator(_box.ItemCollection);
            }

            if (_currentItemEnumerator.MoveNext())
            {
                _CurrentItem = _currentItemEnumerator.Current;
                indexOfItems += 1;
                return true;
            }
            else
            {
                return SetNextBoxEnumerator();
            }

        }

        private bool SetNextBoxEnumerator()
        {
            if (_box.BoxCollection.Count == indexOfBoxes)
            {
                indexOfBoxes = 0;
                return false;
            }
            else
            {
                _CurrentBox = _box.BoxCollection[indexOfBoxes];
                _currentItemEnumerator = new ItemEnumerator(_box.BoxCollection[indexOfBoxes].ItemCollection);
                indexOfBoxes += 1;
                return MoveNext();
            }
        }

        public void Reset()
        {
            indexOfBoxes = 0;
        }
    }
}
