using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;
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
			WriteLine("=> Use Configuration");

			string dataProvider = ConfigurationManager.AppSettings["provider"];
			string connectionString = ConfigurationManager.AppSettings["connectionString"];
			WriteLine($"dataProvider <{dataProvider}>, connectionString <{connectionString}>");

			DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

			using(DbConnection connection = factory.CreateConnection()) {
				if(connection == null) {
					ShowError("Connnection");
					return;
				}
				WriteLine($"Your Connection object is a {connection.GetType().Name}");

				connection.ConnectionString = connectionString;
				connection.Open();

				DbCommand command = factory.CreateCommand();
				if(command == null) {
					ShowError("Command");
					return;
				}
				WriteLine($"Your command object is a {command.GetType().Name}");
				command.Connection = connection;
				command.CommandText = "Select * From Inventory";

				using(DbDataReader reader = command.ExecuteReader()) {
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
