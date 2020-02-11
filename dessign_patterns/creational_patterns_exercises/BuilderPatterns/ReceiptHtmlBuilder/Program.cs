namespace ReceiptHtmlBuilder
{
    using System;
    using ReceiptHtmlBuilder.Models;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {

            var director = new Director();
            var receiptBuilder = new ReceiptBuilder();
            director.Builder = receiptBuilder;
            var header = new Header()
            {
                StoreName = "Semiorochka",
                Cashier = new СashierName() { FirstName = "Lius", MiddleName = "Pavlovich", LastName = "McLonder" }
            };
            var groceries = new List<IBody>();
            var bread = new Grocery()
            {
                Id = 0109890,
                Name = "Bread Borodinskiy",
                Price = 30.50,
                Amounth = 2
            };
            var milk = new Grocery()
            {
                Id = 018797890,
                Name = "Milk Prostokvashino",
                Price = 50.60,
                Amounth = 3
            };
            var eggs = new Grocery()
            {
                Id = 82462490,
                Name = "Eggs Fermersky",
                Price = 10.90,
                Amounth = 10
            };
            groceries.Add(bread);
            groceries.Add(milk);
            groceries.Add(eggs);

            var footer = new Footer()
            {
                ReceiptNumber = 5803498,
                FooterMessage = "Have a good day!!"
            };
            var receipt = new Receipt() 
            {
            Header = header,
            Groceries = groceries,
            Footer = footer
            };

            Console.WriteLine("Standard basic ReceiptHtmlBuilder:");
            Console.WriteLine(director.BuildHtmlReceipt(receipt));

            Console.WriteLine("Custom product:");

            Console.Write(receiptBuilder.Init()
            .BuildHeader(header)
            .BuildBody(groceries)
            .BuildFooter(footer)
            .BuildTemplate()
            .GetResult());
            Console.ReadKey();
        }
    }
}
