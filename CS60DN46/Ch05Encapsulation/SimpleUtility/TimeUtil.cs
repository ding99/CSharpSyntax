using System;
using static System.Console;
using static System.DateTime;

namespace SimpleUtility
{
	static class TimeUtil
	{
		public static void PrintTime() {
			WriteLine(Now.ToShortTimeString());
		}
		public static void PrintDate() {
			WriteLine(Now.ToShortDateString());
		}
	}
}
