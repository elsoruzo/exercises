using System;
using System.Collections.Generic;
using MovingFurnitureAndHouseholdSystem.Models;

namespace MovingFurnitureAndHouseholdSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Item pen = new Item("pen", 1);
            Item pencil = new Item("pencil", 1);
            Item paper = new Item("paper", 1);
            Item desc = new Item("desc", 20);
            desc.SubCollection = new List<Item>() { pen, pencil, paper };

            Item cup = new Item("cup", 2);
            Item spoon = new Item("spoon", 2);
            Item fork = new Item("fork", 2);
            Item plate = new Item("plate", 2);

            Item kitchendraw = new Item("kitchendraw", 50);
            kitchendraw.SubCollection = new List<Item>() { cup, spoon, fork, plate };

            Item goldenRing = new Item("goldenRing", 1);
            Item pearlNeckless = new Item("pearlNeckless", 1);
            Item diamond = new Item("diamond", 1);

            Item jewelrybox = new Item("jewelrybox", 5);
            jewelrybox.SubCollection = new List<Item>() { goldenRing, pearlNeckless, diamond };

            Item tshirt = new Item("tshirt", 1);
            Item pants = new Item("pants", 1);
            Item shirt = new Item("shirt", 1);
            Item pullower = new Item("pullower", 1);

            Item wardrobe = new Item("wardrobe", 50);
            wardrobe.SubCollection = new List<Item>() { tshirt, pants, shirt, pullower, jewelrybox };

            Item chair = new Item("chair", 4);
            Item table = new Item("table", 10);
            Item sofa = new Item("sofa", 30);
            Item computer = new Item("computer", 10);
            ItemsCollectionFilter lightFilter = new ItemsCollectionFilter(new List<Item>() { chair, table, sofa, computer, desc, kitchendraw, wardrobe }, false);
            ItemsCollectionFilter heavyFilter = new ItemsCollectionFilter(new List<Item>() { chair, table, sofa, computer, desc, kitchendraw, wardrobe }, true);


            var enumerator = lightFilter.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.GetNameAndWeight();
            }

            foreach (Item item in heavyFilter)
            {
                item.GetNameAndWeight();
            }


        }
    }
}
