namespace CarBuilder.Models
{
    public interface ICarBuilder
    {
        void Reset();
        void SetSeats();
        void SetEngine();
        void SetTripComputer();
        void SetGps();
    }
}
