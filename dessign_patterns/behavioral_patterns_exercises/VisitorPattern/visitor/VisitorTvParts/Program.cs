namespace FurnitureVisitor
{
    using System.Collections.Generic;
    using FurnitureVisitor.Models;
	class Program
    {
        static void Main(string[] args)
        {
			List<IFurniture> furniture = new List<IFurniture>();
			furniture.Add(new OfficeTable());
			furniture.Add(new OfficeDrower());
			furniture.Add(new OfficeChair());
            FurnitureVisitor furnitureVisitor = new FurnitureVisitor();
            foreach (var piece in furniture)
            {
                piece.Render();
                piece.Accept(furnitureVisitor);
            }
        }
    }
}
