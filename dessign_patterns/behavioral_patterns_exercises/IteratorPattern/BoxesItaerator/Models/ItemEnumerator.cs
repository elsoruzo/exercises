using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BoxesIterator.Models
{
    public class ItemEnumerator : IEnumerator<Item>
    {
        private int _index = 0;
        private List<Item> _itemCollection;
        
        private Item _currentItem { get; set; }


        public ItemEnumerator(List<Item> itemCollection)
        {
            _itemCollection = itemCollection;
        }

        object IEnumerator.Current => (object)Current;
        public Item Current => _currentItem;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (_itemCollection.Count == _index)
            {
                _index = 0;
                return false;
            }
            else
            {
                 _currentItem = _itemCollection[_index];
                 _index += 1;
                 return true;
            }
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
