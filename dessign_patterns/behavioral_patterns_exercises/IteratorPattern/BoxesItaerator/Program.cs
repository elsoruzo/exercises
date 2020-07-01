using System;
using System.Collections.Generic;
using System.Linq;
using BoxesIterator.Models;

namespace BoxesItaerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Box appartment = new Box();

            Item chair = new Item("chair");
            Item table = new Item("table");
            Item sofa = new Item("sofa");
            Item computer = new Item("computer");
            appartment.ItemCollection = new List<Item>(){ chair, table, sofa, computer };

            Item pen = new Item("pen");
            Item pencil = new Item("pencil");
            Item paper = new Item("paper");



            Box desc = new Box();
            desc.ItemCollection = new List<Item>();
            desc.ItemCollection.Add(pen);
            desc.ItemCollection.Add(pencil);
            desc.ItemCollection.Add(paper);



            Item cup = new Item("cup");
            Item spoon = new Item("spoon");
            Item fork = new Item("fork");
            Item plate = new Item("plate");

            Box kitchendraw = new Box();
            kitchendraw.ItemCollection = new List<Item>();
            kitchendraw.ItemCollection.Add(cup);
            kitchendraw.ItemCollection.Add(spoon);
            kitchendraw.ItemCollection.Add(fork);
            kitchendraw.ItemCollection.Add(plate);

            Item tshirt = new Item("tshirt");
            Item pants = new Item("pants");
            Item shirt = new Item("shirt");
            Item pullower = new Item("pullower");

            Box wardrobe = new Box();
            wardrobe.ItemCollection = new List<Item>();
            wardrobe.ItemCollection.Add(tshirt);
            wardrobe.ItemCollection.Add(pants);
            wardrobe.ItemCollection.Add(shirt);
            wardrobe.ItemCollection.Add(pullower);

            Item goldenRing = new Item("goldenRing");
            Item pearlNeckless = new Item("pearlNeckless");
            Item diamond = new Item("diamond");
            Box jewelrybox = new Box();
            jewelrybox.ItemCollection = new List<Item>();
            jewelrybox.ItemCollection.Add(goldenRing);
            jewelrybox.ItemCollection.Add(pearlNeckless);
            jewelrybox.ItemCollection.Add(diamond);
            wardrobe.BoxCollection = new List<Box>(){ jewelrybox };



            appartment.BoxCollection = new List<Box>() { desc, kitchendraw, wardrobe };
            var inspector = new Inspector(appartment);
            inspector.GetAllItems();
            //var enumerator = appartment.GetEnumerator();
            foreach (var item in inspector.FlatItemCollection)
            {
                item.GetName();
            }
            //while (enumerator.MoveNext())
            //{
            //    enumerator.Current.GetName();
            //}
        }
    }
}
