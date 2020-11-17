using System;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using static System.Console;
using System.Configuration;

namespace ConnectionFactory {
	enum DataProvider { SqlServer, OleDb, Odbc, None }

	class Program {
		static void Main() {
			WriteLine("***** Very Simple Connection Factory *****");
			SimpleFactory();
			AppConfig();
			ResetColor();
		}

		private static void AppConfig() {
			ForegroundColor = ConsoleColor.Cyan;
			WriteLine("=> Using Application Configuration Files");

			string conKey = "provider";
			string dataProviderString = ConfigurationManager.AppSettings[conKey];
			WriteLine($"conKey <{conKey}>, string <{dataProviderString}>");
			DataProvider dataProvider = DataProvider.None;
			if(Enum.IsDefined(typeof(DataProvider), dataProviderString)) {
				dataProvider = (DataProvider)Enum.Parse(typeof(DataProvider), dataProviderString);
			} else {
				WriteLine("Sorry, no provider exists!");
				return;
			}

			IDbConnection connection = GetConnection(dataProvider);
			WriteLine($"Your connection is a {connection?.GetType().Name ?? "unrecognized type"}");
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
