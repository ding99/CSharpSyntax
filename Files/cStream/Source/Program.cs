using System;

namespace cStream
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("start");

			string testfile = @"D:\test\testuns\ext\complex_short.uns";
			rewardline rl = new rewardline(args.Length == 0 ? testfile : args[0]);

			bool ret = rl.reRead();
			Console.WriteLine(ret ? "succeeded" : "failed");

			Console.ReadLine();
		}
	}
}
