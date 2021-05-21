using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet {
	class ExamineHashSet {
		public void Start() {
			HashString();
			HashInt();
		}

		private void HashString() {
			Console.ForegroundColor = ConsoleColor.Yellow;

			HashSet<string> languages = new HashSet<string>();
			languages.Add("C");
			languages.Add("C++");
			languages.Add("C#");
			languages.Add("Java");
			languages.Add("Ruby");
			languages.Add("Perl");

			Console.WriteLine($"-- HashSet of String: Languages. Count ({languages.Count})");
			foreach (var a in languages)
				Console.WriteLine(a);
		}

		private void HashInt() {
			Console.ForegroundColor = ConsoleColor.Cyan;

			HashSet<int> ints = new HashSet<int> { 10, 100, 100, 10000, 100000 };

			Console.WriteLine($"-- HashSet of Integer. Count ({ints.Count})");
			foreach (var i in ints)
				Console.WriteLine(i);
		}
	}
}
