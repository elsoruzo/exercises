using System;

namespace StatePetternFan.Models
{
    public class FanHighState : State
    {

        private Fan fan;

        public FanHighState(Fan fan)
        {
            this.fan = fan;
        }

        public override void HandleRequest()
        {
            Console.WriteLine("Turning fan off...");
            fan.SetState(fan.GetFanOffState());
        }

        public override string ToString()
        {
            return "Fan is on high.";
        }
    }
}
