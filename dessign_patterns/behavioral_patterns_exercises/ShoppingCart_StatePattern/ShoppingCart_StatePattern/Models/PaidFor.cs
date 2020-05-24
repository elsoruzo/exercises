using System;

namespace ShoppingCart_StatePattern.Models
{
    public class PaidFor : State
    {
        public PaidFor(Cart cart) : base(cart)
        {
        }

        public override void AddItem()
        {
            Console.WriteLine("You already paid for your purchases. Want to shop some more? Get a new shopping cart!");
        }

        public override void Checkout()
        {
            Console.WriteLine("Why are you back here?  You already paid!");
        }

        public override void EmptyCart()
        {
            Console.WriteLine("You paid already. Time to go home!");
        }

        public override void Pay()
        {
            Console.WriteLine($"You already paid.  You can't pay twice!");
        }

        public override void RemoveItem()
        {
            Console.WriteLine($"You already paid for your purchases and can't remove any.");
        }
    }
}