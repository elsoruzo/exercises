using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkMachineWithPropperFlyweight.Models
{
    public class Cup : IDrinkCupFlyweight
    {
        public string Name { get; set; }

        public int CupSize { get; set; }

        public IDrinkCupFlyweight Drink { get; set; }
        public void Serve()
        {
            Drink.Serve();
        }
    }
}
