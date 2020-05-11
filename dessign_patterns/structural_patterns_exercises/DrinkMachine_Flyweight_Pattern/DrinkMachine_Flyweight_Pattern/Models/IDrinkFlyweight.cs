namespace DrinkMachine.Models
{
    public interface IDrinkFlyweight
    {
        string Name { get; }

        void Serve(string size);
    }
}
