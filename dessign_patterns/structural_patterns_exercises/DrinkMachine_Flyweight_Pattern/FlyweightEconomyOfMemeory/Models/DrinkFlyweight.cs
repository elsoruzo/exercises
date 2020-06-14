using System.Drawing;

namespace FlyweightEconomyOfMemory.Models
{
    public class DrinkFlyweight
    {
        public string Matter { get; set; }
        public bool Shugar = false;
        public string Color { get; set; }
        public Image TextureOfDrink = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Europe_Africa_8k_9-21.jpg");
    }
}
