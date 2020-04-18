namespace VisitorTvParts.Models
{
    public interface ITvPart
    {
        void Accept(ITvPartVisitor visitor);
    }
}
