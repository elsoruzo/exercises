namespace CarBuilder.Models
{
    public interface ICarBuilder
    {
        ICarBuilder Init();
        ICarBuilder SetSeats(int amounth);
        ICarBuilder SetEngine(string type);
        ICarBuilder SetTripComputer();
        ICarBuilder SetGps();
        Car GetResult();
    }
}
