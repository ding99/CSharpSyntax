using System;

namespace cStrings {

	public class testParse {
		public testParse() {
		}

		private void pHex(string s) {
			int n = 0;
			Console.WriteLine("[" + s + "] "+ (Int32.TryParse(s.Trim(),
				System.Globalization.NumberStyles.HexNumber, null, out n) ?
				n.ToString("x") : "(error)"));
			;
		}
		public void parseHex() {
			pHex(" abcd");
			pHex("aa 11");
			pHex("2344");
			pHex("33f33  ");
		}

		public void idex() {
			string s = "Dialogue: Marked=0,0:00:15.00,0:00:18.00,Default,,0000,0000,0000,,At the left we can see...";
			string[] ss = s.Split(',');
			Console.WriteLine(ss.Length);

			string s1 = s.Substring(s.IndexOf(',', 9, 0) + 1);
			Console.WriteLine(s1);
		}

        public void tryone(string s) {
            int d = -1;
            bool ret = int.TryParse(s, out d);
            Console.WriteLine($"tried parse [{s}]. success [{ret}] / value [{d}]");
        }
        public void tryparse() {
            tryone("");
            tryone("-5");
            tryone("498");
            tryone("9-3");
            tryone("aa");
            tryone("-5a");
        }
    }

}
