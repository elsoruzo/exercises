using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart_StatePattern.Models
{
    public class Cart 
    {
        public Empty Empty;

        public NotEmpty NotEmpty;

        public AtCheckOut AtCheckOut;

        public PaidFor PaidFor;

        public int Items;

        public State State;
        public Cart()
        {
            this.Empty = new Empty(this);
            this.NotEmpty = new NotEmpty(this);
            this.AtCheckOut = new AtCheckOut(this);
            this.PaidFor = new PaidFor(this);

            this.Items = 0;
            this.State = this.Empty;
        }

        public void AddItem()
        {
             State.AddItem(this.State);
        }

        public void RemoveItem()
        {
            State.RemoveItem(this.State);
        }

        public void Checkout()
        {
            State.Checkout(this.State);
        }

        public void Pay()
        {
            State.Pay(this.State);
        }

        public void EmptyCart()
        {
            State.EmptyCart(this.State);
        }


    }
}
