namespace DrinkMachineWithPropperFlyweight.Models
{
    public interface IDrinkCupFlyweight
    {
        string Name { get; }

        int CupSize { get; }

        void Serve();
    }
}
