using System;

namespace ActionAndFunc
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Action and Func Telegates *****");
			PracticeAction();
			Console.ResetColor();
		}

		static void PracticeAction()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Practice Action Delegate");

			Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
			actionTarget("Action Message!", ConsoleColor.Yellow, 3);
		}

		static void DisplayMessage(string msg, ConsoleColor color, int count)
		{
			ConsoleColor prev = Console.ForegroundColor;
			Console.ForegroundColor = color;
			for (int i = 0; i < count; i++) Console.WriteLine(msg);
			Console.ForegroundColor = prev;
		}
	}
}
