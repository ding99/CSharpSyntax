using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CRegex {
	public class Replace {
		public Replace() {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("-- Replace");
		}

		private void ReplaceOne(string s) {
			string pattern = "\\s+", replacement = " ";
			Regex r = new Regex(pattern);
			Console.WriteLine($"[{s}] --> [{r.Replace(s, replacement)}]");
		}

		public void Replaces() {
			ReplaceOne("Hello   Expression   !");
			ReplaceOne("One	Two		Three			.");
		}

		public void cmp() {
			Console.WriteLine("-- Replacement Comparison");
			string a = "123456789", b = a, key = "456", target = "ABC";
			string c = a.Replace(key, target);
			string d = new Regex(key).Replace(b, target);

			Console.WriteLine($"General source [{a}] destination [{c}]");
			Console.WriteLine($"Regex   source [{b}] destination [{d}]");
			Console.WriteLine($"Same? [{c == d}]");
		}
	}
}
