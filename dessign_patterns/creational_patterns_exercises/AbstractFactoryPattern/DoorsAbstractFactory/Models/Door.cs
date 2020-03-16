namespace DoorsAbstractFactory.Models
{
    public class Door: IDoor
    {
        public int High { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public string Material { get; set; }
        public string Decoration { get; set; }
        public string Design { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}