using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverArray {
	class Program {
		static void Main() {
			Console.WriteLine("***** Linq to Object *****");
			QueryOverStrings();
			Console.ResetColor();
		}

		static void QueryOverStrings() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Query over strings");
			string[] games = { "Morrowwind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
		}
	}
}
