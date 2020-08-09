namespace StaticData
{
	class SavingsAccount1
	{
		public double balance;
		public static double interestRate = 0.04;
		public SavingsAccount1(double balance) { this.balance = balance; }

		public static void SetInterestRate(double newRate) { interestRate = newRate; }
		public static double GetInterestRate() { return interestRate; }
	}
}
