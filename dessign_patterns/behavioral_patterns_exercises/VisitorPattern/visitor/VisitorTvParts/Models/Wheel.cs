namespace VisitorTvParts.Models
{

    public class Wheel : ITvPart
    {
        public void Accept(ITvPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
