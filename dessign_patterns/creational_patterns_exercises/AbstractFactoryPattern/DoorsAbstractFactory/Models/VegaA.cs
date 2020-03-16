namespace DoorsAbstractFactory.Models
{
    public class VegaA: IDoor
    {
        public int High { get; set; } = 192;
        public int Width { get; set; } = 73;
        public int Depth { get; set; } = 12;
        public string Material { get; set; } = "Metal";
        public string Decoration { get; set; } = "Vegetables";
        public string Design { get; set; }
        public string Model { get; set; } = "VegaA";
        public string Color { get; set; }
    }
}