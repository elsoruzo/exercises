using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FlyweightEconomyOfMemory.Models
{
    public class ColdDrinkCupFlyweight
    {
        public int Size = 300;
        public bool Stick = false;
        public Image TextureOfCup = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmerica_8k_9-21.jpg");
    }
}
