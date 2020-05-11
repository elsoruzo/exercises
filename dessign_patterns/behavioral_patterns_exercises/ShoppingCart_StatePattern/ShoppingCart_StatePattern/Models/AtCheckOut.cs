using System;

namespace ShoppingCart_StatePattern.Models
{
    public  class AtCheckOut : State
    {
        public AtCheckOut(Cart cart) : base(cart)
        {
        }

        public override void AddItem(State state)
        {
            Console.WriteLine("You can't add items at the check out counter.");
        }

        public override void Checkout(State state)
        {
            Console.WriteLine("You're already at checkout.");
        }

        public override void EmptyCart(State state)
        {
            Cart.Items = 0;
            Cart.State = Cart.Empty;
            Console.WriteLine("Your cart is empty again.");
        }

        public override void Pay(State state)
        {
            Console.WriteLine($"You paid for { Cart.Items } items.");
            Cart.State = Cart.PaidFor;
        }

        public override void RemoveItem(State state)
        {
            Cart.Items -= 1;
            if (Cart.Items > 0)
            {
                Console.WriteLine($"You now have {Cart.Items} items in your cart.");
            }

            else
            {
                Console.WriteLine($"Your cart is empty again.");
                Cart.State = Cart.Empty;
            }
        }
    }
}