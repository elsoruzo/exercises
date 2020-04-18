namespace VisitorTvParts.Models
{
    public class Fender : ITvPart
    {
        public void Accept(ITvPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
