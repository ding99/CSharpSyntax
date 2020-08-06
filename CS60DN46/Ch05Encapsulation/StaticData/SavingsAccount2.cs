namespace StaticData
{
	class SavingsAccount2
	{
		public double balance;
		public static double interestRate;
		public SavingsAccount2(double balance) { 
			this.balance = balance;
			interestRate = 0.04;
		}

		public static void SetInterestRate(double newRate) { interestRate = newRate; }
		public static double GetInterestRate() { return interestRate; }
	}
}
