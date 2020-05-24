using System;

namespace ShoppingCart_StatePattern.Models
{
    public class NotEmpty : State
    {
        public NotEmpty(Cart cart) : base(cart)
        {
        }

        public override void AddItem()
        {
            Cart.Items += 1;
            Console.WriteLine($"You now have {Cart.Items} items in your cart.");
        }

        public override void Checkout()
        {
            Console.WriteLine("Done shopping. Let's check out!");
            Cart.State = Cart.AtCheckOut;
        }

        public override void EmptyCart()
        {
            Console.WriteLine("Your can only empty the cart at checkout.");
        }

        public override void Pay()
        {
            Console.WriteLine("You have to go to checkout to pay!");
        }

        public override void RemoveItem()
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
