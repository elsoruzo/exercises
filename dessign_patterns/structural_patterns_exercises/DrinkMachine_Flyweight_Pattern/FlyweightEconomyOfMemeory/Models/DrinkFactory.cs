using System;
using System.Drawing;
using FlyweightEconomyOfMemory.Models;

namespace DrinkMachineWithHeavyEntity.Models
{
    public class DrinkFactory
    {

        private HotDrinkCupFlyweight cupForHotDrinkFlyweight = new HotDrinkCupFlyweight();
        private ColdDrinkCupFlyweight cupForColdDrinkFlyweight = new ColdDrinkCupFlyweight();
        private DrinkFlyweight drinkFlyweight =  new DrinkFlyweight();
        public Drink GetDrink(string drinkKey)
        {

            switch (drinkKey)
            {
                case "Espresso":
                    drinkFlyweight.Matter = "Espresso";
                    drinkFlyweight.Color = "Brown";
                    return new Drink()
                    {
                        Matter = drinkFlyweight.Matter,
                        Shugar = drinkFlyweight.Shugar,
                        Color = drinkFlyweight.Color,
                        TextureOfDrink = drinkFlyweight.TextureOfDrink,
                        Size = cupForHotDrinkFlyweight.Size,
                        Stick = cupForHotDrinkFlyweight.Stick,
                        TextureOfCup = cupForHotDrinkFlyweight.TextureOfCup,
                        Price = 3.59
                    };
                case "Coffee":
                    drinkFlyweight.Matter = "Coffee";
                    drinkFlyweight.Color = "Black";
                    return new Drink()
                    {
                        Matter = drinkFlyweight.Matter,
                        Shugar = drinkFlyweight.Shugar,
                        Color = drinkFlyweight.Color,
                        TextureOfDrink = drinkFlyweight.TextureOfDrink,
                        Size = cupForHotDrinkFlyweight.Size,
                        Stick = cupForHotDrinkFlyweight.Stick,
                        TextureOfCup = cupForHotDrinkFlyweight.TextureOfCup,
                        Price = 3.89
                    };
                case "Tea":
                    drinkFlyweight.Matter = "Tea";
                    drinkFlyweight.Color = "Brown";
                    return new Drink()
                    {
                        Matter = drinkFlyweight.Matter,
                        Shugar = drinkFlyweight.Shugar,
                        Color = drinkFlyweight.Color,
                        TextureOfDrink = drinkFlyweight.TextureOfDrink,
                        Size = cupForHotDrinkFlyweight.Size,
                        Stick = cupForHotDrinkFlyweight.Stick,
                        TextureOfCup = cupForHotDrinkFlyweight.TextureOfCup,
                        Price = 1.59
                    };
                case "CocaCola":
                    drinkFlyweight.Matter = "CocaCola";
                    drinkFlyweight.Color = "Black";
                    return new Drink()
                    {
                        Matter = drinkFlyweight.Matter,
                        Shugar = drinkFlyweight.Shugar,
                        Color = drinkFlyweight.Color,
                        TextureOfDrink = drinkFlyweight.TextureOfDrink,
                        Size = cupForColdDrinkFlyweight.Size,
                        Stick = cupForColdDrinkFlyweight.Stick,
                        TextureOfCup = cupForColdDrinkFlyweight.TextureOfCup,
                        Price = 6.59
                    };
                case "Pepsi":
                    drinkFlyweight.Matter = "Pepsi";
                    drinkFlyweight.Color = "Black";
                    return new Drink()
                    {
                        Matter = drinkFlyweight.Matter,
                        Shugar = drinkFlyweight.Shugar,
                        Color = drinkFlyweight.Color,
                        TextureOfDrink = drinkFlyweight.TextureOfDrink,
                        Size = cupForColdDrinkFlyweight.Size,
                        Stick = cupForColdDrinkFlyweight.Stick,
                        TextureOfCup = cupForColdDrinkFlyweight.TextureOfCup,
                        Price = 7.59
                    };
                case "Sprite":
                    drinkFlyweight.Matter = "Sprite";
                    drinkFlyweight.Color = "Transparent";
                    return new Drink()
                    {
                        Matter = drinkFlyweight.Matter,
                        Shugar = drinkFlyweight.Shugar,
                        Color = drinkFlyweight.Color,
                        TextureOfDrink = drinkFlyweight.TextureOfDrink,
                        Size = cupForColdDrinkFlyweight.Size,
                        Stick = cupForColdDrinkFlyweight.Stick,
                        TextureOfCup = cupForColdDrinkFlyweight.TextureOfCup,
                        Price = 3.59
                    };
                default:
                    throw new Exception("This is not a flyweight drink object...");
            }

        }

    }
}
