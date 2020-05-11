using System;
using System.Collections.Generic;

namespace DrinkMachine.Models
{
    public class Espresso : IDrinkFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }
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

        public void Serve(string size)
        {
            Console.WriteLine($"- {size} {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }
}
