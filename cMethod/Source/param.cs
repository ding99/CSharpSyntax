using System;

namespace cMethod {

	public class cPrm {
		public cPrm() {
		}

		public void iscalled(string m, int i1, int i2 = 5) {
			Console.WriteLine("== " + m);
			Console.WriteLine("  i1[" + i1 + "] i2[" + i2 + "]");
		}

		public void checkprm() {
			this.iscalled("one param", 3);
			this.iscalled("two params", 3, 10);
		}
	}

	class Program {
		static void Main(string[] args) {
			//(new cPrm()).checkprm();
			
			cMemo cm = new cMemo();
			cm.checkmemos();
		}
	}
}
