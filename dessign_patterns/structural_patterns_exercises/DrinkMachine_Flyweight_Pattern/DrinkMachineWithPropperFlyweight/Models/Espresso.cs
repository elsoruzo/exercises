using System;
using System.Collections.Generic;

namespace DrinkMachineWithPropperFlyweight.Models
{
    public class Espresso : IDrinkCupFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }

        public int CupSize { get; set; }

        private IEnumerable<string> _ingredients;

        public Espresso()
        {
            _name = "Espresso";
            _ingredients = new List<string>()
            {
                "Coffee Beans",
                "Hot Water"
            };
        }

        public void Serve()
        {
            Console.WriteLine($"- Cup size {CupSize} ml. {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }
}
