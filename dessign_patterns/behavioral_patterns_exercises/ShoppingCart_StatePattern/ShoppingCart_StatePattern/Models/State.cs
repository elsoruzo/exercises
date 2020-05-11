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

        public abstract void AddItem(State state);

        public abstract void RemoveItem(State state);

        public abstract void Checkout(State state);

        public abstract void Pay(State state);

        public abstract void EmptyCart(State state);

    }
}
