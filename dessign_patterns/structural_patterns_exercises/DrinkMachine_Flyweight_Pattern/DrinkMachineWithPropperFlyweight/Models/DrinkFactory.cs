using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkMachineWithPropperFlyweight.Models
{
    public class DrinkFactory
    {
        private Dictionary<int, Cup> _cupStorage = new Dictionary<int, Cup>();
        public int ObjectsCreated = 0;

        public IDrinkCupFlyweight GetDrink(int cupKey, string drinkKey)
        {
            Cup cup = null;

            if (_cupStorage.ContainsKey(cupKey))
            {
                Console.WriteLine("\nReusing existing flyweight object.");
                cup = _cupStorage[cupKey];
            }
            else
            {
                cup = new Cup() { CupSize = cupKey };
                Console.WriteLine("\nCreating new flyweight object.");
                _cupStorage.Add(cupKey, cup);
            }


            switch (drinkKey)
            {
                case "Espresso":
                    cup.Drink = new Espresso() { CupSize = cupKey };
                    break;
                case "Coffee":
                    cup.Drink = new Coffee() { CupSize = cupKey };
                    break;
                case "Tea":
                    cup.Drink = new Tea() { CupSize = cupKey };
                    break;
                case "CocaCola":
                    cup.Drink = new CocaCola() { CupSize = cupKey };
                    break;
                case "Pepsi":
                    cup.Drink = new Pepsi() { CupSize = cupKey };
                    break;
                case "Sprite":
                    cup.Drink = new Sprite() { CupSize = cupKey };
                    break;
                default:
                    throw new Exception("This is not a flyweight drink object...");
            }

            ObjectsCreated++;

            return cup.Drink;
        }

        public void ListDrinks()
        {
            Console.WriteLine($"\nFactory has {_cupStorage.Count} drink objects ready to use.");
            Console.WriteLine($"Number of objects created: {ObjectsCreated}");

            foreach (var drink in _cupStorage)
                Console.WriteLine($"\t{drink.Value.Name}");

            Console.WriteLine("\n");
        }
    }
}
