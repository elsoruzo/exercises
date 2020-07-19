using System;
using System.Collections;
using System.Collections.Generic;

namespace MovingFurnitureAndHouseholdSystem.Models
{
    internal class HeavyItemsUnboxerStackEnumerator : IEnumerator<Item>
    {
        private Item _CurrentItem { get; set; }

        private Stack<Item> _itemsStackToUnbox = new Stack<Item>();

        public HeavyItemsUnboxerStackEnumerator(ItemsCollectionUnboxerFilter itemsCollection)
        {
            //itemsCollection._items.Reverse();
            foreach (var item in itemsCollection._items)
            {
                _itemsStackToUnbox.Push(item);
            }
        }

        public Item Current => _CurrentItem;

        object IEnumerator.Current => (object)Current;

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }


        /// <summary>
        /// Recursive.
        /// </summary>
        //public bool MoveNext()
        //{
        //    Item curentItem;
        //    if (!_itemsStackToUnbox.TryPop(out curentItem))
        //    {
        //        return false;
        //    }

        //    int weigh = 0;

        //    weigh = curentItem.GetWeight();

        //    if (weigh < 30)
        //    {
        //        _CurrentItem = curentItem;
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"start unpacking Item:");
        //        curentItem.GetNameAndWeight();
        //        Console.WriteLine($"finished unpacking Item:");
        //        foreach (var item in curentItem.SubCollection)
        //        {
        //            _itemsStackToUnbox.Push(item);
        //        }

        //        return MoveNext();
        //    }
        //}

        /// <summary>
        /// Iterative.
        /// </summary>
        public bool MoveNext()
        {
            var curentItem = GetItemFromStack();
            if (curentItem == null) return false;


            if (IsItemPropperWeight(curentItem))
            {
                SetCurrentItem(curentItem);
                return true;
            }

            while (curentItem != null)
            {

                if (IsItemPropperWeight(curentItem))
                {
                    SetCurrentItem(curentItem);
                    return true;
                }
                else
                {
                    Console.WriteLine($"start unpacking Item:");
                    curentItem.GetNameAndWeight();
                    Console.WriteLine($"finished unpacking Item:");
                    foreach (var item in curentItem.SubCollection)
                    {
                        _itemsStackToUnbox.Push(item);
                    }
                    curentItem = GetItemFromStack();
                }

            }

            return true;

        }

        private void SetCurrentItem(Item curentItem)
        {
            _CurrentItem = curentItem;
        }

        private bool IsItemPropperWeight(Item curentItem)
        {
            var weigh = curentItem.GetWeight();
            if (weigh < 30)
            {
                return true;
            }

            return false;
        }

        private Item GetItemFromStack()
        {
            Item curentItem = null;
            if (_itemsStackToUnbox.TryPop(out curentItem))
            {
                return curentItem;
            }

            return curentItem;
        }

        public void Reset()
        {
            Console.WriteLine($"Reset was called");
        }
    }
}