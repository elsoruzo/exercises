using System.Collections.Generic;
using BoxesIteratorRecursion.Models;

namespace BoxesIteratorRecursion
{
        class Program
        {
            static void Main(string[] args)
            {
                Item pen = new Item("pen");
                Item pencil = new Item("pencil");
                Item paper = new Item("paper");



                Box box = new Box();
                box.ItemCollection = new List<Item>();
                box.ItemCollection.Add(pen);
                box.ItemCollection.Add(pencil);
                box.ItemCollection.Add(paper);


                Item cup = new Item("cup");
                Item spoon = new Item("spoon");
                Item fork = new Item("fork");
                Item plate = new Item("plate");

                Box box0InCollection = new Box();
                box0InCollection.ItemCollection = new List<Item>();
                box0InCollection.ItemCollection.Add(cup);
                box0InCollection.ItemCollection.Add(spoon);
                box0InCollection.ItemCollection.Add(fork);
                box0InCollection.ItemCollection.Add(plate);

                Item tshirt = new Item("tshirt");
                Item pants = new Item("pants");
                Item shirt = new Item("shirt");
                Item pullower = new Item("pullower");

                Box box1InCollection = new Box();
                box1InCollection.ItemCollection = new List<Item>();
                box1InCollection.ItemCollection.Add(tshirt);
                box1InCollection.ItemCollection.Add(pants);
                box1InCollection.ItemCollection.Add(shirt);
                box1InCollection.ItemCollection.Add(pullower);

                box.BoxCollection = new List<Box>();
                box.BoxCollection.Add(box0InCollection);
                box.BoxCollection.Add(box1InCollection);
                box.BoxCollection[1].BoxCollection = new List<Box>();
                box.BoxCollection[1].BoxCollection.Add(box1InCollection);

                var enumerator = box.GetEnumerator();
                foreach (var item in box)
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
