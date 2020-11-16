using System;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using static System.Console;

namespace ConnectionFactory {
	enum DataProvider { SqlServer, OleDb, Odbc, None }

	class Program {
		static void Main() {
			WriteLine("***** Very Simple Connection Factory *****");
			SimpleFactory();
			ResetColor();
		}

		private static void SimpleFactory() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Connection Factory");

			IDbConnection connection = GetConnection(DataProvider.SqlServer);
			WriteLine($"Your connnection is a {connection.GetType().Name}");

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
