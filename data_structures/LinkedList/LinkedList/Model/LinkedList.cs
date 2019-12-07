using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Model
{
    class LinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }

        public Item<T> Tail { get; private set; }

        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            if(Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        public void Delete(T data)
        {
            if (Head.Data != null)
            {

                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };

            Head = item;
            Count++;
        }
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while(current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        /********************************************************************************/

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }

        /********************************************************************************/

        internal class LinkedListEnumerator : IEnumerator<T>
        {
            private bool _isFirstTimeMoveNext = true;
            private Item<T> _current;
            private LinkedList<T> _doublyLinkedList;

            public LinkedListEnumerator(LinkedList<T> list)
            {
                this._doublyLinkedList = list;
                this._current = list.Head;
            }

            public T Current
            {
                get { return this._current.Data ; }
            }

            object System.Collections.IEnumerator.Current
            {
                get { return _isFirstTimeMoveNext ? throw new InvalidOperationException() : Current ; }
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
}
