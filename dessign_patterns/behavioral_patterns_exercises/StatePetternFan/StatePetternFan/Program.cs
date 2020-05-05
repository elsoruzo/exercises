using System;
using StatePetternFan.Models;

namespace StatePetternFan
{
    class Program
    {
        static void Main(string[] args)
        {
			Fan fan = new Fan();

			Console.WriteLine(fan.state);

			fan.PullChain();

			Console.WriteLine(fan.state);

			fan.PullChain();

			Console.WriteLine(fan.state);

			fan.PullChain();


			Console.WriteLine(fan.state);

			fan.PullChain();

			Console.WriteLine(fan.state);
		}
    }
}
