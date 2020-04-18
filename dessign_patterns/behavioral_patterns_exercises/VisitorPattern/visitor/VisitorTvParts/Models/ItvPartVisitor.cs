namespace VisitorTvParts.Models
{
    public interface ITvPartVisitor
    {
        void Visit(Wheel wheel);
        void Visit(Fender fender);
        void Visit(Oil oil);
        void Visit(PartsOrder partsOrder);
    }
}
