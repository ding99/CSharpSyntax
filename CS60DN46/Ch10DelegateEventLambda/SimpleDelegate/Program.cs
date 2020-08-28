using System;

namespace SimpleDelegate
{
	public delegate int BinaryOp(int x, int y);

	public class SimpleMath
	{
		public static int Add(int x, int y) { return x + y; }
		public static int Subtract(int x, int y) { return x - y; }
		public int AddObject(int x, int y) { return x + y; }
		public int SubtractObject(int x, int y) { return x - y; }
	}

	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Simple Delegate Example *****");
			InvestigateObject();
			BySimpleDelegate();
			Console.ResetColor();
		}

		static void InvestigateObject()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Investigate Delegate Object (static method)");
			BinaryOp b = new BinaryOp(SimpleMath.Add);
			DisplayDelegateInfo(b);
			Console.WriteLine("-> Investigate Delegate Object (non-static method)");
			BinaryOp b2 = new BinaryOp(new SimpleMath().AddObject);
			DisplayDelegateInfo(b2);
		}

		static void DisplayDelegateInfo(Delegate deleg)
		{
			foreach(Delegate d in deleg.GetInvocationList())
				Console.WriteLine($"   Method <{d.Method}>, Type <{d.Target}>");
		}

		static void BySimpleDelegate()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> First simple example");

			int x = 20, y = 10;
			BinaryOp b = new BinaryOp(SimpleMath.Add);
			Console.WriteLine($"{x} + {y} is {b(x, y)}");
			b = new BinaryOp(SimpleMath.Subtract);
			Console.WriteLine($"{x} - {y} is {b(x, y)}");
		}
	}
}
