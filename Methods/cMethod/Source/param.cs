using System;

namespace CMethod {

	public class CPrm {
		public CPrm() {
		}

		public void iscalled(string m, int i1, int i2 = 5) {
			Console.WriteLine("== " + m);
			Console.WriteLine("  i1[" + i1 + "] i2[" + i2 + "]");
		}

		public void checkPrm() {
			this.iscalled("one param", 3);
			this.iscalled("two params", 3, 10);
		}
	}
}
