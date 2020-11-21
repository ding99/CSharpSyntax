using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using static System.Console;

namespace FillDataSetUsingDataAdapter {
	class Program {
		static void Main() {
			WriteLine("***** Fun with Data Adapter *****");
			FetchData();
			ResetColor();
		}

		private static void FetchData() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Fetch data from database");

			string connectionString = "Integrated Security=SSPI;Initial Catalog=AutoLot;Data Source=(local)";
			DataSet ds = new DataSet("AutoLot");

			SqlDataAdapter adapter = new SqlDataAdapter("Select * From Inventory", connectionString);

			WriteLine($"The number of rows is {adapter.Fill(ds, "Inventory")}.");

			PrintDataSet(ds);
		}

		private static void PrintDataSet(DataSet d) {

		}
	}
}
