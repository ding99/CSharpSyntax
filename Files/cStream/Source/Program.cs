using System;

namespace CStream
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("start");

			string testfile = @"D:\test\testuns\ext\complex_short.uns";
			RewardLine rl = new RewardLine(args.Length == 0 ? testfile : args[0]);

			bool ret = rl.reRead();
			Console.WriteLine(ret ? "succeeded" : "failed");

			Console.ReadLine();
		}
	}
}
