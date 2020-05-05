using System;

namespace FurnitureVisitor.Models
{
    public class OfficeChair : IFurniture
    {
        public string Id = "OfficeChair";
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
