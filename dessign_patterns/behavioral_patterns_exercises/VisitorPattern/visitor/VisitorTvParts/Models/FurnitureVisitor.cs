namespace FurnitureVisitor.Models
{
    using System;

    public class FurnitureVisitor : IFurnitureVisitor
    {
        private Prices prices = new Prices(); 

        public void Visit(OfficeTable table)
        {
            var price = prices.Id_Price[table.Id];
            Console.WriteLine($"The price for table is {price}");
        }

        public void Visit(OfficeDrower drower)
        {
            var price = prices.Id_Price[drower.Id];
            Console.WriteLine($"The price for drower is {price}");
        }

        public void Visit(OfficeChair chair)
        {
            var price = prices.Id_Price[chair.Id];
            Console.WriteLine($"The price for chair is {price}");
        }
    }
}