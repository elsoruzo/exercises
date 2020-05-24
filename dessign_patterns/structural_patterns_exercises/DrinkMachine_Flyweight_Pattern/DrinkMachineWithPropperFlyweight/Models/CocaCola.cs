using System;
using System.Collections.Generic;

namespace DrinkMachineWithPropperFlyweight.Models
{
    public class CocaCola : IDrinkCupFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }

        public int CupSize { get; set; }

        private IEnumerable<string> _ingredients;

        public CocaCola()
        {
            _name = "CokeCola";
            _ingredients = new List<string>()
            {
                "Coffee Beans",
                "Fizzy Water",
                "Suggar",
                "Cola Essence"
            };
        }

        public void Serve()
        {
            Console.WriteLine($"- Cup size {CupSize} ml. {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }
}