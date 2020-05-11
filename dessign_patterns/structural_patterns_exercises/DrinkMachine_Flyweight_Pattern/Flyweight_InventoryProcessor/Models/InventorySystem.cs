using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryProcessor.Models
{
    public class InventorySystem
    {
		private Catalog catalog = new Catalog();
		private List<Order> orders = new List<Order>();

		public void TakeOrder(string itemName, int orderNumber)
		{
			Item item = catalog.Lookup(itemName);
			Order order = new Order(orderNumber, item);
			orders.Add(order);
		}

		public void Process()
		{
			for (int i = 0; i < orders.Count; i++)
			{
				Order order = orders[i];
				order.ProcessOrder();
				orders.Select(x => x.OrderNumber != order.OrderNumber);
			}
		}

		public string Report()
		{
			return "\nTotal Item objects made: "
					+ catalog.TotalItemsMade();
		}
	}
}
