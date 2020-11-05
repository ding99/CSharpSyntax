using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;

namespace ConnectionFactory {
	class Program {
		static void Main() {
			Console.WriteLine("***** Very Simple Connection Factory *****");
			SimpleFactory();
			Console.ResetColor();
		}

		private static void SimpleFactory() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Connection Factory");
		}
	}
}
