namespace DoorsAbstractFactory.Models
{
    public interface IDoor
    {
        int High { get; set; }
        int Width { get; set; }
        int Depth { get; set; }
        string Material { get; set; }
        string Decoration { get; set; }
        string Design { get; set; }
        string Model { get; set; }
        string Color { get; set; }
    }
}