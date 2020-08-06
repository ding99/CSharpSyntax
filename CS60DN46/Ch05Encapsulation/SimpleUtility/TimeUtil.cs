using System;

namespace SimpleUtility
{
	static class TimeUtil
	{
		public static void PrintTime() {
			Console.WriteLine(DateTime.Now.ToShortTimeString());
		}
		public static void PrintDate() {
			Console.WriteLine(DateTime.Now.ToShortDateString());
		}
	}
}
