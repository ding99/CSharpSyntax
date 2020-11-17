using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using static System.Console;

namespace DataProviderFactory {
	class Program {
		static void Main() {
			WriteLine("***** Data Provider Factories *****");
			GetFactory();
			ResetColor();
		}

		private static void GetFactory() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Provider Factory");
		}
	}
}
