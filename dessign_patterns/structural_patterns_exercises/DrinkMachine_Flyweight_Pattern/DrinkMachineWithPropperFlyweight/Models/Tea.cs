using System;
using System.Collections.Generic;

namespace DrinkMachineWithPropperFlyweight.Models
{
    public class Tea : IDrinkCupFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }

        public int CupSize { get; set; }

        private IEnumerable<string> _ingredients;

        public Tea()
        {
            _name = "Sprite";
            _ingredients = new List<string>()
            {
                "Hot Water",
                "Tea leaves",
            };
        }

        public void Serve()
        {
            Console.WriteLine($"- Cup size {CupSize} ml. {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }
}