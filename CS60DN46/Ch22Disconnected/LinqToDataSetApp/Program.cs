using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.DataSet;
using AutoLotDAL.DataSet.AutoLotDataSetTableAdapters;
using System.Data;
using static System.Console;

namespace LinqToDataSetApp {
	class Program {
		static void Main() {
			WriteLine("***** Linq over DataSet *****");
			UseEnumerable();
			ResetColor();
		}

		private static void UseEnumerable() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Linq-Complatible DataTable");

			AutoLotDataSet dal = new AutoLotDataSet();
			InventoryTableAdapter adapter = new InventoryTableAdapter();
			AutoLotDataSet.InventoryDataTable data = adapter.GetData();

			PrintAllCarIDs(data);
			ShowBalckCars(data);
		}

		private static void ShowBalckCars(DataTable data) {
			ForegroundColor = ConsoleColor.Cyan;

			var cars = from car in data.AsEnumerable() where (string)car["Color"] == "Black" select new { ID = (int)car["CarID"], Make = (string)car["Make"] };
			WriteLine($"Here are the black cars we have in stock (size {cars.Count()}) :");
			foreach (var item in cars)
				WriteLine($"CarID = {item.ID} is {item.Make}");
		}

		private static void PrintAllCarIDs(DataTable data) {
			EnumerableRowCollection enumData = data.AsEnumerable();
			Write($"All Cars with IDs:");
			foreach (DataRow r in enumData)
				Write($" {r["CarID"]}");
			WriteLine();
		}
	}
}
