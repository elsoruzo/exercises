namespace VisitorTvParts.Models
{
    using System.Collections.Generic;

    public class PartsOrder : ITvPart
    {

        private List<ITvPart> parts = new List<ITvPart>();

        public void AddPart(ITvPart atvPart)
        {
            parts.Add(atvPart);
        }

        public List<ITvPart> GetParts()
        {
            return parts;
        }

        public void Accept(ITvPartVisitor visitor)
        {
            foreach (ITvPart atvPart in parts)
            {
                atvPart.Accept(visitor);
            }
            visitor.Visit(this);
        }
    }
}