namespace DoorsAbstractFactory.Models
{
    public class SedaA : IDoor
    {
        public int High { get; set; } = 190;
        public int Width { get; set; } = 70;
        public int Depth { get; set; } = 10;
        public string Material { get; set; } = "Wood";
        public string Decoration { get; set; } = "Dragons";
        public string Design { get; set; }
        public string Model { get; set; } = "SedaA";
        public string Color { get; set; }
    }
}