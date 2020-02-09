namespace CarBuilder.Models
{
    public interface IReceiptBuilder
    {
        void Reset();
        void SetSeats(int amounth);
        void SetEngine(string type);
        void SetTripComputer();
        void SetGps();
    }
}
