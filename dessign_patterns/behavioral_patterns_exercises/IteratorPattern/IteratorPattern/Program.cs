namespace IteratorPattern
{
    using System;
    using IteratorPattern.Models;

    public class Program
    {
        public static void Main(string[] args)
        {
            var left = new Item();
            var right = new Item();
            Iinventory inv = new HandHeldInventory(left, right);
            IinventoryIterator iter = inv.GetIterator();
            while (iter.IsDone())
            {
                Item item = iter.GetCurrent();
                Console.WriteLine(item);
                iter.GoNext();
            }

        }
    }
}
