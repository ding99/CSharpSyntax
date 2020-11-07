using System;
using System.Linq;
using System.Collections.Generic;

namespace cStrings {
	class Evaluation {

		public void ExamineOrder() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- ReOrder numbers according to their weight");

			ReOrder("4444 2000 123 99 103");

			Console.WriteLine("-- Class End");
		}

		private void ReOrder(string s) {
			string[] c = s.Split(' ');

			IList<string> ns = new List<string>(c);

			var or = ns.OrderBy(m => Weight(m)).ThenBy(m => m.Length);

			var ordered = from ss in ns orderby Weight(ss) select ss;

			var r = string.Join(" ", or.ToArray());

			Console.WriteLine($"Input  [{s}]");
			Console.WriteLine($"Output [{r}]");
		}
		private int Weight(string m) {
			long n;
			if (!Int64.TryParse(m, out n))
				return 0;

			int l = m.Length;
			int sum = 0;
			for (int i = 0; i < l; i++)
				sum += Int32.Parse(m[i].ToString());

			return sum;
		}


		public void ExamineBase64() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- Base64 Encoding");

			/*
				
				
			*/
			EncodeOne("this is a string!!", "dGhpcyBpcyBhIHN0cmluZyEh");
			EncodeOne("this is a test!", "dGhpcyBpcyBhIHRlc3Qh");
		}

		private void EncodeOne(string src, string tgt) {
			Console.WriteLine($"src [{tgt}]");
			Console.WriteLine($"tgt [{EncodeBase64(src)}]");
		}

		public string EncodeBase64(string str) {
			#region table
			char[] tbl = new char[65];
			for (int i = 0; i < 26; i++) {
				tbl[i] = (char)('A' + i);
				tbl[26 + i] = (char)('a' + i);
				if (i < 10)
					tbl[52 + i] = (char)('0' + i);
			}
			tbl[62] = '+';
			tbl[63] = '/';
			tbl[64] = '=';
			#endregion

			#region encoding
			string s = string.Empty;
			int l = str.Length;

			for (int i = 0; i < l; i += 3) {
				if (i + 2 == l) {
					s += tbl[(str[i] >> 2) & 0x3f];
					s += tbl[((str[i] & 3) << 4)];
					s += tbl[64];
					s += tbl[64];
					break;
				} else if (i + 1 == l) {
					s += tbl[(str[i] >> 2) & 0x3f];
					s += tbl[((str[i] & 3) << 4) + (tbl[i + 1] >> 4) & 0xf];
					s += tbl[((str[i + 1] & 0xf) << 2)];
					s += tbl[64];
					break;
				}

				s += tbl[(str[i] >> 2) & 0x3f];
				s += tbl[((str[i] & 3) << 4) | ((str[i + 1] >> 4) & 0xf)];
				s += tbl[((str[i + 1] & 0xf) << 2) | (str[i + 2] >> 6) & 3];
				s += tbl[str[i + 2] & 0x3f];
			}
			#endregion

			return s;
		}
	}
}
