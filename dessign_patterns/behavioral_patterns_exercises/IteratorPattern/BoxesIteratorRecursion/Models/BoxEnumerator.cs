using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BoxesIteratorRecursion.Models
{
    public class BoxEnumerator : IEnumerator<Item>
    {
        private int indexOfBoxes = 0;
        private int indexOfItems = 0;
        private bool isItemEnumeratorForItemCollection = true;
        private IEnumerator<Item> _currentItemEnumerator { get; set; }
        private Item _CurrentItem { get; set; }
        private Box _CurrentBox;
        private Box _box;
        public BoxEnumerator(Box box)
        {
            _CurrentBox = box;
            isTopLevel = true;
        }

        public Item Current => _CurrentItem;

        object IEnumerator.Current => (object)Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (isItemEnumeratorForItemCollection)
            {
                _currentItemEnumerator = new ItemEnumerator(_CurrentBox.ItemCollection);
                isItemEnumeratorForItemCollection = false;
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
            if (_CurrentBox.BoxCollection.Count == indexOfBoxes)
            {
                indexOfBoxes = 0;
                return false;
            }
            else
            {
                _CurrentBox = _CurrentBox.BoxCollection[indexOfBoxes];
                _currentItemEnumerator = _CurrentBox.GetEnumerator();
                isItemEnumeratorForItemCollection = true;
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
