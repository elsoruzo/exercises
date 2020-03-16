namespace DoorsAbstractFactory.Models
{
    public interface IDoorBlooprint
    {
        int High { get; set; }
        int Width { get; set; }
        int Depth { get; set; }
        string Material { get; set; }
        string Color { get; set; }
    }
}