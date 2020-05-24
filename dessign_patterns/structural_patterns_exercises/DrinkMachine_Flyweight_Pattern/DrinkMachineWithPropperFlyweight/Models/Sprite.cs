using System;
using System.Collections.Generic;

namespace DrinkMachineWithPropperFlyweight.Models
{
    public class Sprite : IDrinkCupFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }

        public int CupSize { get; set; }

        private IEnumerable<string> _ingredients;

        public Sprite()
        {
            _name = "Sprite";
            _ingredients = new List<string>()
            {
                "Lemon",
                "Lime",
                "Fizzy Water",
                "Suggar",
                "Pepsi essence"
            };
        }

        public void Serve()
        {
            Console.WriteLine($"- Cup size {CupSize} ml. {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }
}