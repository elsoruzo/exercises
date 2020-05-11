using System;

namespace InventoryProcessor.Models
{
	public class Order
	{
		public int OrderNumber;
		public Item Item;

		public Order(int orderNumber, Item item)
		{
			this.OrderNumber = orderNumber;
			this.Item = item;
		}

		public void ProcessOrder()
		{
			Console.WriteLine("Ordering " + Item + " for order number " + OrderNumber);
		}
	}
}
