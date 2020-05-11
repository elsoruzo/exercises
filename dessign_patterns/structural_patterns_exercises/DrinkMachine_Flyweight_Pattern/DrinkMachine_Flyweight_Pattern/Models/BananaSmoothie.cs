using System;
using System.Collections.Generic;

namespace DrinkMachine.Models
{
    public class BananaSmoothie : IDrinkFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }
        private IEnumerable<string> _ingredients;

        public BananaSmoothie()
        {
            _name = "Banana Smoothie";
            _ingredients = new List<string>()
            {
                "Banana",
                "Whole Milk",
                "Vanilla Extract"
            };
        }

        public void Serve(string size)
        {
            Console.WriteLine($"- {size} {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }
}
