namespace Employees
{
	public class Outer
	{
		public class PublicInner {
			public double GetBenefit() { return 50.0; }
		}

		private string GetPrivateString()
		{
			return "Private string in Nesting";
		}

		private class PrivateInner {
			public double InnerValue() {  return 35.0; }
			public string UpperString()
			{
				return new Outer().GetPrivateString();
			}
		}

		public double PrivateValue()
		{
			PrivateInner privateInner = new PrivateInner();
			return privateInner.InnerValue();
		}

		public string PrivateString()
		{
			return new PrivateInner().UpperString();
		}
	}
}
