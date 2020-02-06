namespace CarBuilder.Models
{
    public interface ICar
    {
        string Engine { get; set; }
        int Seats { get; set; }
        bool IsHasGps { get; set; }
        bool IsHasTripComputer { get; set; }
    }
}