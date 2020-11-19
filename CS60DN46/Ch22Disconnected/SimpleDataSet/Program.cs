using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SimpleDataSet {
	class Program {
		static void Main() {
			Console.WriteLine("***** Fun with DataSets *****");

			CreateData();

			Console.ResetColor();
		}

		private static void CreateData() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Create DataSet");
		}
	}
}
