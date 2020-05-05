using System;
using System.Collections.Generic;
using System.Text;

namespace StatePetternFan.Models
{
	public abstract class State
	{

		public virtual void HandleRequest()
		{
			Console.WriteLine("Shouldn't be able to get here.");
		}
	}
}
