using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;

namespace ConnectionFactory {
	enum DataProvider { SqlServer, OleDb, Odbc, None }

	class Program {
		static void Main() {
			Console.WriteLine("***** Very Simple Connection Factory *****");
			SimpleFactory();
			Console.ResetColor();
		}

		private static void SimpleFactory() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Connection Factory");

			IDbConnection connection = GetConnection(DataProvider.SqlServer);
			Console.WriteLine($"Your connnection is a {connection.GetType().Name}");

		}

		static IDbConnection GetConnection(DataProvider provider) {
			IDbConnection connection = null;
			switch (provider) {
				case DataProvider.SqlServer:
					connection = new SqlConnection();
					break;
				case DataProvider.OleDb:
					connection = new OleDbConnection();
					break;
				case DataProvider.Odbc:
					connection = new OdbcConnection();
					break;
			}
			return connection;
		}
	}
}
