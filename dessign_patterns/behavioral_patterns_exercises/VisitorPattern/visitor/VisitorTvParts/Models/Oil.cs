namespace VisitorTvParts.Models
{

    public class Oil : ITvPart
    {
        public void Accept(ITvPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
