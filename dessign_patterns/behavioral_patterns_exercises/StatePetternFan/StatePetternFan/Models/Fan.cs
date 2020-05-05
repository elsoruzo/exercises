using System;

namespace StatePetternFan.Models
{
	public class Fan
	{

		State fanOffState;
		State fanLowState;
		State fanMedState;
		State fanHighState;

		State state;

		public Fan()
		{
			fanOffState = new FanOffState(this);
			fanLowState = new FanLowState(this);
			fanMedState = new FanMedState(this);
			fanHighState = new FanHighState(this);

			state = fanOffState;
		}

		public void PullChain()
		{
			state.HandleRequest();
		}

		public String ToString()
		{
			return state.ToString();
		}

		public State GetFanOffState()
		{
			return fanOffState;
		}

		public State GetFanLowState()
		{
			return fanLowState;
		}

		public State GetFanMedState()
		{
			return fanMedState;
		}

		public State GetFanHighState()
		{
			return fanHighState;
		}

		public void SetState(State state)
		{
			this.state = state;
		}
	}
}
