using System;

namespace ShoppingCart_StatePattern.Models
{
    public class NotEmpty : State
    {
        public NotEmpty(Cart cart) : base(cart)
        {
        }

        public override void AddItem(State state)
        {
            Cart.Items += 1;
            Console.WriteLine($"You now have {Cart.Items} items in your cart.");
        }

        public override void Checkout(State state)
        {
            Console.WriteLine("Done shopping. Let's check out!");
            Cart.State = Cart.AtCheckOut;
        }

        public override void EmptyCart(State state)
        {
            Console.WriteLine("Your can only empty the cart at checkout.");
        }

        public override void Pay(State state)
        {
            Console.WriteLine("You have to go to checkout to pay!");
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
