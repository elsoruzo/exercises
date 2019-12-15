using System;
using System.Collections;

namespace data_structures.SLinkedListModel
{
    class LinkedListEnumerator<T> : IEnumerator
    {
        private bool _isFirstTimeMoveNext = true;
        private SLinkedListItem<T> _current;
        private SLinkedListItem<T> _nullCurrent;
        private SLinkedList<T> _doublyLinkedList;

        public LinkedListEnumerator(SLinkedList<T> sLinkedList)
        {
            this._doublyLinkedList = sLinkedList;
            this._current = sLinkedList.Head;
            this._nullCurrent = new SLinkedListItem<T>((T)Activator.CreateInstance(typeof(T)));
        }

        public T Current
        {
            get { return _isFirstTimeMoveNext ? this._nullCurrent.Data : this._current.Data; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            if (_isFirstTimeMoveNext)
                _isFirstTimeMoveNext = false;
            else
                _current = _current.Next;

            return (this._current != null);
        }

        public void Reset()
        {
            _isFirstTimeMoveNext = true;
            _current = _doublyLinkedList.Head;
        }

        public void Dispose()
        {
            _current = null;
            _isFirstTimeMoveNext = true;
            _doublyLinkedList = null;
        }
    }
}
