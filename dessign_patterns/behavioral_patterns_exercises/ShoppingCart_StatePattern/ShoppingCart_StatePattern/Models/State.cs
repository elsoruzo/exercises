using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart_StatePattern.Models
{
    public abstract class State
    {
        internal Cart Cart;
        public State(Cart cart)
        {
            this.Cart = cart;
        }

        public abstract void AddItem();

        public abstract void RemoveItem();

        public abstract void Checkout();

        public abstract void Pay();

        public abstract void EmptyCart();

    }
}
