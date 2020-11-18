﻿using System;
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
				string connectionString = @"Data Source=(local);Integrated Security=SSPI;" + "Initial Catalog=AutoLot";
				//or Security=true
				connection.ConnectionString = connectionString;
				connection.Open();

				WriteLine($"(1) timeout {connection.ConnectionTimeout}, source {connection.DataSource} (lenght {connection.DataSource.Length}), state {connection.State}");

				string sql = "Select * From Inventory";
				SqlCommand command = new SqlCommand(sql, connection);

				using(SqlDataReader reader = command.ExecuteReader()) {
					while (reader.Read())
						WriteLine($"-> Make: {reader["Make"]}, PetName: {reader["PetName"]}.");
				}

				connection.Close(); //?
				WriteLine($"(2) timeout {connection.ConnectionTimeout}, source {connection.DataSource} (lenght {connection.DataSource.Length}), state {connection.State}");
			}
		}
	}
}
