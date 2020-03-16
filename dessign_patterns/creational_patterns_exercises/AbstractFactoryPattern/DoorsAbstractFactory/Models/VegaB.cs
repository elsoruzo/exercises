namespace DoorsAbstractFactory.Models
{
    public class VegaB: IDoor
    {
        public int High { get; set; } = 193;
        public int Width { get; set; } = 74;
        public int Depth { get; set; } = 13;
        public string Material { get; set; } = "Wood";
        public string Decoration { get; set; } = "Fruits";
        public string Design { get; set; }
        public string Model { get; set; } = "VegaB";
        public string Color { get; set; }
    }
}