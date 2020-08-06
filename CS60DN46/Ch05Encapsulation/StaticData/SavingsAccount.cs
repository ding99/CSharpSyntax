﻿namespace StaticData
{
	class SavingsAccount
	{
		public double balance;
		public static double interestRate = 0.04;
		public SavingsAccount(double balance) { this.balance = balance; }

		public static void SetInterestRate(double newRate) { interestRate = newRate; }
		public static double GetInterestRate() { return interestRate; }
	}
}
