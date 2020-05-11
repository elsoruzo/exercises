using System;

namespace DrinkMachine.Models
{
    /// <summary>
    /// Unshared concrete flyweight
    /// </summary>
    public class DrinkGiveaway : IDrinkFlyweight
    {
        /// <summary>
        /// All state
        /// </summary>
        public string Name { get { return _randomDrink.Name; } }
        private IDrinkFlyweight[] _eligibleDrinks = new IDrinkFlyweight[]
        {
            new Espresso(),
            new BananaSmoothie()
        };

        private IDrinkFlyweight _randomDrink;
        private string _size;

        public DrinkGiveaway()
        {
            var randomIndex = new Random().Next(0, 2);
            _randomDrink = _eligibleDrinks[randomIndex];
        }

        /// <summary>
        /// Extrinsic state
        /// </summary>
        public void Serve(string size)
        {
            _size = size;
            Console.WriteLine($"Free Giveaway!");
            Console.WriteLine($"- {_size} {_randomDrink.Name} coming up!");
            _randomDrink.Serve(size);
        }
    }
}
