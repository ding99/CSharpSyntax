using System;
using System.Data.SqlClient;
using static System.Console;

namespace AutoLotDataReader {
	class Program {
		static void Main() {
			WriteLine("***** Data Readers *****");
			DataReader();
			ResetColor();
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
