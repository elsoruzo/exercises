using System;

namespace ObserverPattern.Models
{
    public class PhoneClient : Observer
    {
        public PhoneClient(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Attach(this);
        }

        public void AddMessage(string message)
        {
            Subject.SetState(message + " - sent from phone");
        }

        public override void Update()
        {
            Console.WriteLine("Phone Stream: " + Subject.GetState());
        }

	}
}
