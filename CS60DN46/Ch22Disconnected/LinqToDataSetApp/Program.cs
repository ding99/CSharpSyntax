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
			UseLinq();
			ResetColor();
		}

		private static void UseLinq() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Linq-Complatible DataTable");

			AutoLotDataSet dal = new AutoLotDataSet();
			InventoryTableAdapter adapter = new InventoryTableAdapter();
			AutoLotDataSet.InventoryDataTable data = adapter.GetData();

			PrintAllCarIDs(data);
		}

		private static void PrintAllCarIDs(DataTable data) {
			EnumerableRowCollection enumData = data.AsEnumerable();
			foreach (DataRow r in enumData)
				WriteLine($"Car ID = {r["CarID"]}");
		}
	}
}
