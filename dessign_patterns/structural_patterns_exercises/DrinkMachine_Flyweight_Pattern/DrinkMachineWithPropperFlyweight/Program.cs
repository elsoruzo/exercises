using DrinkMachineWithPropperFlyweight.Models;
using System;

namespace DrinkMachineWithPropperFlyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinkFactory = new DrinkFactory();

            var largeEspresso = drinkFactory.GetDrink(500,"Espresso");
            largeEspresso.Serve();

            var mediumCoffee = drinkFactory.GetDrink(250, "Coffee");
            mediumCoffee.Serve();

            var mediumEspresso = drinkFactory.GetDrink(250, "Espresso");
            mediumEspresso.Serve();

            var mediumTea = drinkFactory.GetDrink(250, "Tea");
            mediumTea.Serve();

            var largeCocaCola = drinkFactory.GetDrink(500, "CocaCola");
            largeCocaCola.Serve();

            var largeSprite = drinkFactory.GetDrink(500, "Sprite");
            largeSprite.Serve();

            var largePepsi = drinkFactory.GetDrink(500, "Pepsi");
            largePepsi.Serve();

            var mediumSprite = drinkFactory.GetDrink(500, "Sprite");
            mediumSprite.Serve();

            drinkFactory.ListDrinks();
        }
    }
}
