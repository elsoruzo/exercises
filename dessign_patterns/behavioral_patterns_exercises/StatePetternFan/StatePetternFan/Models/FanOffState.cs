using System;

namespace StatePetternFan.Models
{
	public class FanOffState : State
	{

		private Fan fan;

		public FanOffState(Fan fan)
		{
			this.fan = fan;
		}


		public override void HandleRequest()
		{
			Console.WriteLine("Turning fan on to low.");
			fan.SetState(fan.GetFanLowState());
		}

		public String toString()
		{
			return "Fan is off.";
		}
	}
}
