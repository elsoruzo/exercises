using System;

namespace FurnitureVisitor.Models
{
    public class OfficeDrower : IFurniture
    {
        public string Id = "OfficeDrower";
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
