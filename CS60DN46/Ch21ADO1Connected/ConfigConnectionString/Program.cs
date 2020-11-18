using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;
using static System.Console;

namespace ConfigConnectionString {
	class Program {
		static void Main() {
			WriteLine("***** connectionStrings in Config File *****");
			UseConfig();
			ResetColor();
		}

		private static void UseConfig() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Use connectionStrings");

			string dataProvider = ConfigurationManager.AppSettings["provider"];
			string connectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
			//connectionString = ConfigurationManager.ConnectionStrings["AutoLotOleDbProvider"].ConnectionString;

			WriteLine($"dataProvider <{dataProvider}>, connectionString <{connectionString}>");

			DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

			using (DbConnection connection = factory.CreateConnection()) {
				if (connection == null) {
					ShowError("Connnection");
					return;
				}
				WriteLine($"Your Connection object is a {connection.GetType().Name}");

				connection.ConnectionString = connectionString;
				connection.Open();

				var sqlConnection = connection as System.Data.SqlClient.SqlConnection;
				if (sqlConnection != null)
					WriteLine($"Sql Connnection version is {sqlConnection.ServerVersion}");
				else WriteLine("This is not a Sql Connection");

				DbCommand command = factory.CreateCommand();
				if (command == null) {
					ShowError("Command");
					return;
				}
				WriteLine($"Your command object is a {command.GetType().Name}");
				command.Connection = connection;
				command.CommandText = "Select * From Inventory";

				using (DbDataReader reader = command.ExecuteReader()) {
					WriteLine($"Your data reader object is a {reader.GetType().Name}");

					WriteLine("----- Current Inventory -----");
					while (reader.Read())
						WriteLine($"-> Car #{reader["CarId"]} is a {reader["Make"]} with a color {reader["Color"]}");
				}
			}
		}

		private static void ShowError(string objectName) {
			WriteLine($"There was an issue creating the {objectName}");
		}
	}
}
