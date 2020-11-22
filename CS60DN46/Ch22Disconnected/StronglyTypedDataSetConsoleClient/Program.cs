using AutoLotDAL.DataSet;
using AutoLotDAL.DataSet.AutoLotDataSetTableAdapters;
using System;
using static System.Console;

namespace StronglyTypedDataSetConsoleClient {
	class Program {
		static void Main() {
			WriteLine("***** Strongly Typed DataSets *****");
			UseLib();
			ResetColor();
		}

		private static void UseLib() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Use AutoLogDAL library version 3");

			var table = new AutoLotDataSet.InventoryDataTable();

			var adapter = new InventoryTableAdapter();

			adapter.Fill(table);

			PrintInventory(table);
		}

		private static void PrintInventory(AutoLotDataSet.InventoryDataTable t) {
			for (int col = 0; col < t.Columns.Count; col++)
				Write($"{t.Columns[col].ColumnName}\t");
			WriteLine();
			WriteLine("-------------------------------------");

			for(int row = 0; row < t.Rows.Count; row++) {
				for (int col = 0; col < t.Columns.Count; col++)
					Write($"{t.Rows[row][col]}\t");
				WriteLine();
			}
		}
	}
}
