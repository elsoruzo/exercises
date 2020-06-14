using System.Drawing;

namespace FlyweightEconomyOfMemory.Models
{
    public class HotDrinkCupFlyweight
    {
        public int Size = 250;
        public bool Stick = false;
        public Image TextureOfCup = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmerica_8k_9-21.jpg");
    }
}
