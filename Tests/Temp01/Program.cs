using System;

namespace Temp01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("== Start");

			Entrance entry = new Entrance();
			entry.Start();

			Console.WriteLine("== End");
		}
	}
}
