using System;

namespace StaticData
{
	class SavingsAccount3
	{
		public double balance;
		public static double interestRate;
		public SavingsAccount3(double balance)
		{
			this.balance = balance;
		}
		static SavingsAccount3()
		{
			Console.WriteLine("In static ctor!");
			interestRate = 0.04;
		}

		public static void SetInterestRate(double newRate) { interestRate = newRate; }
		public static double GetInterestRate() { return interestRate; }
	}
}
