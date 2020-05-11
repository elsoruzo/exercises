using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProcessor.Models
{
	public class Catalog
	{
		private Dictionary<string, Item> items = new Dictionary<string, Item>();

		//factory method
		public Item Lookup(string itemName)
		{
			if (!items.ContainsKey(itemName))
			{
				items.Add(itemName, new Item(itemName));
			}

			return items[itemName];
		}

		public int TotalItemsMade()
		{
			return items.Count;
		}
	}
}
