﻿using System;

namespace StaticData
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Static Data *****");
			StaticData();
			StaticInit();
			Console.ResetColor();
		}

		static void StaticInit()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;

			SavingsAccount2 s1 = new SavingsAccount2(50);
			Console.WriteLine($"Interest Rate is {SavingsAccount2.GetInterestRate()}");

			SavingsAccount2.SetInterestRate(0.08);
			Console.WriteLine($"Interest Rate is {SavingsAccount2.GetInterestRate()}");

			SavingsAccount2 s2 = new SavingsAccount2(100);
			Console.WriteLine($"Interest Rate is {SavingsAccount2.GetInterestRate()}");
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
