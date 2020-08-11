namespace Employees
{
	public class Outer
	{
		public class PublicInner {
			public double GetBenefit() { return 50.0; }
		}

		private class PrivateInner
		{
			public double InnerValue() { return 35.0; }
			public string UpperString()
			{
				return new Outer().GetPrivateString();
			}
		}

		private string GetPrivateString()
		{
			return "Private string in Nesting";
		}

		public double PrivateValue()
		{
			return new PrivateInner().InnerValue();
		}

		public string PrivateString()
		{
			return new PrivateInner().UpperString();
		}
	}
}
