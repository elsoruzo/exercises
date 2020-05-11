using System;
using ShoppingCart_StatePattern.Models;

namespace ShoppingCart_StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====> first cart");
            var cart = new Cart();
            cart.AddItem();
            cart.RemoveItem();
            cart.AddItem();
            cart.AddItem();
            cart.AddItem();
            cart.RemoveItem();
            cart.Checkout();
            cart.Pay();

            // Go shopping again
            Console.WriteLine("====> second cart");
            cart = new Cart();
            cart.AddItem();
            cart.AddItem();
            cart.Checkout();
            cart.EmptyCart();
            cart.AddItem();
            cart.Checkout();
            cart.Pay();

            // Try to add another item
            Console.WriteLine("====> Expect an error here.");
            cart.AddItem();
        }
    }
}
