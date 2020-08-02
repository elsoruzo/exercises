using System;

namespace ObserverPattern.Models
{
    public class TabletClient : Observer
    {
        public TabletClient(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Attach(this);
        }

        public void AddMessage(string message)
        {
            Subject.SetState(message + " - sent from tablet");
        }

        public override void Update()
        {
            Console.WriteLine("Tablet Stream: " + Subject.GetState());
        }

	}
}
