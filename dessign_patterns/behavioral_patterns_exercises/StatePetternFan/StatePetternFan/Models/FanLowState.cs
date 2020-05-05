using System;

namespace StatePetternFan.Models
{
    public class FanLowState : State
    {

        private Fan fan;

        public FanLowState(Fan fan)
        {
            this.fan = fan;
        }

        public override void HandleRequest()
        {
            Console.WriteLine("Turning fan on to med.");
            fan.SetState(fan.GetFanMedState());
        }

        public override string ToString()
        {
            return "Fan is low.";
        }
    }
}
