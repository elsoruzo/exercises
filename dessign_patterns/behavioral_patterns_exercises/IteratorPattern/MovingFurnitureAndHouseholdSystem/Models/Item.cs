using System;
using System.Collections.Generic;

namespace MovingFurnitureAndHouseholdSystem.Models
{

    public class Item : IItem
    {
        public List<Item> SubCollection { get; set; }
        private string _name;
        private int _weight = 0;
        public Item(string itemName, int itemWeight){ _name = itemName; _weight = itemWeight; }

        public void GetNameAndWeight()
        {
            Console.WriteLine($"{_name}  {_weight}");
        }

        public int GetWeight()
        {

            if (SubCollection != null)
            {
                foreach (var item in SubCollection)
                {
                    _weight = _weight + item.GetWeight();
                }
            }


            return _weight;
        }

        public List<Item> GetFlatSubcollection()
        {
            List<Item> flatItems = new List<Item>();
            flatItems.Add(this);
            if (SubCollection != null)
            {
                foreach (var item in SubCollection)
                {
                    flatItems.AddRange(item.GetFlatSubcollection());
                }
            }


            return flatItems;
        }
    }
}