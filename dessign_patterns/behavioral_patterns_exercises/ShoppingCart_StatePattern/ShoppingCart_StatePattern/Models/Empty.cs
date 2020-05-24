using System;

namespace ShoppingCart_StatePattern.Models
{
    public class Empty : State 
    {
        public Empty(Cart cart) : base(cart)
        {
        }

        public override void AddItem()
        {
            Cart.Items += 1;
            Console.WriteLine("You added the first item");
            Cart.State = Cart.NotEmpty;
        }

        public override void Checkout()
        {
            Console.WriteLine("Your cart is empty. Go shopping!");
        }

        public override void EmptyCart()
        {
            Console.WriteLine("Your cart is already empty.");
        }

        public override void Pay()
        {
            Console.WriteLine("Your cart is empty. How did you get here?");
        }

        public override void RemoveItem()
        {
            Console.WriteLine("Your cart is empty! Nothing to remove!!");
        }
    }
}