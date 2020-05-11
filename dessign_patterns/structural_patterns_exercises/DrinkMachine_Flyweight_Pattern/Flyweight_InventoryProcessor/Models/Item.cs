
namespace InventoryProcessor.Models
{
	public class Item
	{
		private readonly string name;

		public Item(string name)
		{
			this.name = name;
		}

		public override string ToString()
		{
			return name;
        }
    }
}
