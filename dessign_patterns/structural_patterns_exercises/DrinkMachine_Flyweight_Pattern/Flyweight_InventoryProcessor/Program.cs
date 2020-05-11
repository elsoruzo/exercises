using System;
using InventoryProcessor.Models;

namespace InventoryProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
			InventorySystem ims = new InventorySystem();

			ims.TakeOrder("Honor Phone", 221);
			ims.TakeOrder("Samsung Headphones", 361);
			ims.TakeOrder("Samsung Phone", 432);
			ims.TakeOrder("Samsung Phone", 323);
			ims.TakeOrder("Honor Phone", 563);
			ims.TakeOrder("Samsung Headphones", 321);
			ims.TakeOrder("Honor Phone", 234);
			ims.TakeOrder("Samsung Phone", 54);
			ims.TakeOrder("Honor Phone", 34);
			ims.TakeOrder("Samsung Headphones", 365);
			ims.TakeOrder("Samsung Phone", 332);
			ims.TakeOrder("Honor Phone", 456);

			ims.Process();
			Console.WriteLine(ims.Report());
        }
    }
}
