using System;
using System.Drawing;
namespace DrinkMachineWithHeavyEntity.Models
{
    public class Drink
    {
        public string Matter { get; set; } 
        public bool Shugar { get; set; }
        public string Color { get; set; }
        public Image TextureOfDrink { get; set; }
        public int  Size { get; set; }
        public bool Stick { get; set; }
        public Image TextureOfCup { get; set; }
        public double Price { get; set; }

	}
}
