using System;

namespace StaticData
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Static Data *****");
			StaticData();
			Console.ResetColor();
		}

		static void StaticData()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			SavingsAccount s1 = new SavingsAccount(50);
			Console.WriteLine($"Interest Rate is {SavingsAccount.GetInterestRate()}");

			SavingsAccount.SetInterestRate(0.05);
			SavingsAccount s2 = new SavingsAccount(100);
			Console.WriteLine($"Interest Rate is {SavingsAccount.GetInterestRate()}");
			
			SavingsAccount s3 = new SavingsAccount(10000.75);
			Console.WriteLine($"Interest Rate is {SavingsAccount.GetInterestRate()}");
		}
	}
}
