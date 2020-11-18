using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
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
				connection.ConnectionString = connectionString;
				connection.Open();

				string sql = "Select * From Inventory";
				SqlCommand command = new SqlCommand(sql, connection);

				using(SqlDataReader reader = command.ExecuteReader()) {
					while (reader.Read())
						WriteLine($"-> Make: {reader["Make"]}, PetName: {reader["PetName"]}.");
				}
			}
		}
	}
}
