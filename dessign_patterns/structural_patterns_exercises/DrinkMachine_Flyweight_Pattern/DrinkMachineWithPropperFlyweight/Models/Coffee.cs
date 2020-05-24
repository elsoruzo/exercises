using System;
using System.Collections.Generic;

namespace DrinkMachineWithPropperFlyweight.Models
{
    public class Coffee : IDrinkCupFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }

        public int CupSize  { get; set; }

        private IEnumerable<string> _ingredients;

        public Coffee()
        {
            _name = "Coffee";
            _ingredients = new List<string>()
            {
                "Coffee",
                "Whole Milk",
                "Vanilla Extract"
            };
        }

        public void Serve()
        {
            Console.WriteLine($"- Cup size {CupSize} ml. {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }
}