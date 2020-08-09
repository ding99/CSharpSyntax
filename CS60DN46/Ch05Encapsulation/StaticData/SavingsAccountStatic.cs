namespace StaticData
{
	class SavingsAccountStatic
	{
		public double balance;
		private static double interestRate = 0.04;
		public SavingsAccountStatic(double balance) { this.balance = balance; }

		public static double InterestRate {
			get { return interestRate; }
			set { interestRate = value; }
		}
	}
}
