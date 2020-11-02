using System;

namespace CLambda {
	public class Test{
		public Test() {
		}

		public void Lamb01() {
			byte[] a = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
			Array.ForEach(a, x=>Console.Write(x + " "));
			Console.WriteLine();
		}
	}
}
