using System;
using System.Data.SqlClient;
using static System.Console;

namespace AutoLotDataReader {
	class Program {
		static void Main() {
			WriteLine("***** Data Readers *****");
			DataReader();
			UseBuilder();
			MultiResult();
			ResetColor();
		}

		private static void MultiResult() {
			ForegroundColor = ConsoleColor.DarkYellow;
			WriteLine("=> Multi Result Sets");

			string connectionString = @"Data Source=(local);Integrated Security=SSPI;" + "Initial Catalog=AutoLot;Timeout=20";

			using (SqlConnection connection = new SqlConnection()) {
				connection.ConnectionString = connectionString;
				connection.Open();
				ShowConnectionStatus(connection);

				string sql = "select * from Inventory;select * from Customers";
				SqlCommand command = new SqlCommand(sql, connection);

				using (SqlDataReader reader = command.ExecuteReader()) {
					do {
						while (reader.Read()) {
							for (int i = 0; i < reader.FieldCount; i++)
								Write($"{reader.GetName(i)}: {reader.GetValue(i)}, ");
							WriteLine();
						}
					} while (reader.NextResult());
				}
			}
		}

		private static void UseBuilder() {
			ForegroundColor = ConsoleColor.Cyan;
			WriteLine("=> Working with ConnectionStringBuilder Object");

			var builder = new SqlConnectionStringBuilder {
				InitialCatalog = "AutoLot",
				DataSource = ".",
				ConnectTimeout = 18,
				IntegratedSecurity = true
			};

			using(SqlConnection connection = new SqlConnection()) {
				connection.ConnectionString = builder.ConnectionString;
				connection.Open();
				ShowConnectionStatus(connection);

				string sql = "Select * From Inventory";
				SqlCommand command = new SqlCommand(sql, connection);

				command.CommandType = System.Data.CommandType.Text; //default

				using (SqlDataReader reader = command.ExecuteReader())
					while (reader.Read()) {
						for (int i = 0; i < reader.FieldCount; i++)
							Write($"{reader.GetName(i)}: {reader.GetValue(i)}, ");
						WriteLine();
					}

				connection.Close();
			}
		}

		private static void DataReader() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> SqlClient");

			using(SqlConnection connection = new SqlConnection()) {
				string connectionString = @"Data Source=(local);Integrated Security=SSPI;" + "Initial Catalog=AutoLot;Timeout=20";
				//or Security=true
				connection.ConnectionString = connectionString;
				connection.Open();
				ShowConnectionStatus(connection);

				string sql = "Select * From Inventory";
				SqlCommand command = new SqlCommand(sql, connection);

				using(SqlDataReader reader = command.ExecuteReader()) {
					while (reader.Read())
						WriteLine($"-> Make: {reader["Make"]}, PetName: {reader["PetName"]}.");
				}

				connection.Close();
				ShowConnectionStatus(connection);
			}
		}

		private static void ShowConnectionStatus(SqlConnection connection) {
			WriteLine("----- Info about your connection -----");
			WriteLine($"Database Location: {connection.DataSource}");
			WriteLine($"Database Name    : {connection.Database}");
			WriteLine($"Timeout          : {connection.ConnectionTimeout}");
			WriteLine($"Connection State : {connection.State}");
		}
	}
}
