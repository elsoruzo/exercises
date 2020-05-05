using System;

namespace FurnitureVisitor.Models
{

    public class OfficeTable : IFurniture
    {
        public string Id = "OfficeTable";
        public void Accept(IFurnitureVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void Render()
        {
            Console.WriteLine($"Rendering... {Id}");
        }
    }
}
