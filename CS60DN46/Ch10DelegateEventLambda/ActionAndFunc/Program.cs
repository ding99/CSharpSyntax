using System;

namespace ActionAndFunc
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Action and Func Telegates *****");
			PracticeAction();
			PracticeFunc();
			Console.ResetColor();
		}

		static void PracticeFunc()
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Practice Func Delegate");

			#region return int
			int x = 20, y = 30;

			Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
			int result = funcTarget.Invoke(x,y);
			int result2 = funcTarget(x, y);
			Console.WriteLine($"{x} + {y} = {result} ({result2})");

			#region method group conversion
			Func<int, int, int> funcTarget11 = Add;
			int result11 = funcTarget11.Invoke(x, y);
			int result112 = funcTarget11(x, y);
			Console.WriteLine($"{x} + {y} = {result11} ({result112})");
			#endregion method group conversion
			#endregion return int

			#region return string
			x = 50; y = 60;
			Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
			string sum = funcTarget2(x, y);
			Console.WriteLine($"{x} + {y} = {sum}");
			#endregion return string
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

		static int Add(int x, int y) { return x + y; }
		static string SumToString(int x, int y) { return (x + y).ToString(); }
	}
}
