namespace FurnitureVisitor.Models
{
    public interface IFurnitureVisitor
    {
        void Visit(OfficeTable table);
        void Visit(OfficeDrower drower);
        void Visit(OfficeChair chair);
    }
}
