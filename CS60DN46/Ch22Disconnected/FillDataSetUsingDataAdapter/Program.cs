using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;
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

			DataTableMapping mapping = adapter.TableMappings.Add("Inventory", "Current Inventory");
			mapping.ColumnMappings.Add("CarId", "Car Id");
			mapping.ColumnMappings.Add("PetName", "Name of Car");

			WriteLine($"The number of rows is {adapter.Fill(ds, "Inventory")}.");

			PrintDataSet(ds);
		}

		private static void PrintDataSet(DataSet s) {
			WriteLine($"DataSet is named : {s.DataSetName}");

			ConsoleColor org = ForegroundColor;
			ForegroundColor = ConsoleColor.DarkYellow;

			foreach (DictionaryEntry de in s.ExtendedProperties)
				WriteLine($"Key = {de.Key}, Value = {de.Value}");
			foreach (DataTable t in s.Tables) {
				WriteLine($"<> {t.TableName} Table:");
				for (int col = 0; col < t.Columns.Count; col++)
					Write($"{t.Columns[col].ColumnName}\t");
				WriteLine();
				WriteLine("--------------------------------");
				for(int row = 0; row < t.Rows.Count; row++) {
					for (int col = 0; col < t.Columns.Count; col++)
						Write($"{t.Rows[row][col].ToString().Trim()}\t");
					WriteLine();
				}
			}

			ForegroundColor = org;
		}
	}
}
