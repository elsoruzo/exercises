using System.Collections.Generic;

namespace FurnitureVisitor.Models
{
    public class Prices
    {
        public Prices()
        {
            Id_Price.Add("OfficeTable", 20.60);
            Id_Price.Add("OfficeChair", 10.30);
            Id_Price.Add("OfficeDrower", 15.50);
        }
        public Dictionary<string, double> Id_Price =
                      new Dictionary<string, double>();
    }
}
