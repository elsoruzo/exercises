using System;


namespace StatePetternFan.Models
{
    public class FanMedState : State
    {

        private Fan fan;

        public FanMedState(Fan fan)
        {
            this.fan = fan;
        }

        public override void HandleRequest()
        {
            Console.WriteLine("Turning fan on to high...");
            fan.SetState(fan.GetFanHighState());
        }

        public override string ToString()
        {
            return "Fan is on med.";
        }
    }
}
