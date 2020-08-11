namespace Employees
{
	public class Outer
	{
		public class PublicInner {
			public double GetBenefit() { return 50.0; }
		}

		private class PrivateInner {
			public double InnerValue() {  return 35.0; }
		}

		public double PrivateValue()
		{
			PrivateInner privateInner = new PrivateInner();
			return privateInner.InnerValue();
		}
	}
}
