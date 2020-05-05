namespace FurnitureVisitor.Models
{
    public interface IFurniture
    {
        void Accept(IFurnitureVisitor visitor);
        void Render();
    }
}
