namespace DoorsAbstractFactory.Models
{
    public class SedaB: IDoor
    {
        public int High { get; set; } = 191;
        public int Width { get; set; } = 71;
        public int Depth { get; set; } = 11;
        public string Material { get; set; } = "Metal";
        public string Decoration { get; set; } = "Dinosors";
        public string Design { get; set; }
        public string Model { get; set; } = "SedaB";
        public string Color { get; set; }
    }
}