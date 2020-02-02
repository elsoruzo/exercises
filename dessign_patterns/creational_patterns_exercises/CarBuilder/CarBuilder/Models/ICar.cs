namespace CarBuilder.Models
{
    public interface ICar
    {
        void SetSeats(int amounth);
        void SetEngine(string type);
        void SetTripComputer();
        void SetGps();
    }
}