using AutoLotDAL.DataSet;
using AutoLotDAL.DataSet.AutoLotDataSetTableAdapters;
using System;
using static System.Console;

namespace StronglyTypedDataSetConsoleClient {
	class Program {
		static void Main() {
			WriteLine("***** Strongly Typed DataSets *****");
			ShowTable();
			AddRows();
			ResetColor();
		}

		private static void AddRows() {
			ForegroundColor = ConsoleColor.Cyan;
			WriteLine("=> Add Two Rows Using AutoLogDAL library version 3");

			var table = new AutoLotDataSet.InventoryDataTable();
			var adapter = new InventoryTableAdapter();
			adapter.Fill(table);

			AddRecords(table, adapter);
			table.Clear();
			adapter.Fill(table);
			PrintInventory(table);
		}

		private static void AddRecords(AutoLotDataSet.InventoryDataTable table, InventoryTableAdapter adapter) {
			AutoLotDataSet.InventoryRow newRow = table.NewInventoryRow();
			newRow.Color = "Purple";
			newRow.Make = "BMW";
			newRow.PetName = "Saku";
			table.AddInventoryRow(newRow);

			table.AddInventoryRow("Yugo", "Green", "Zippy");

			adapter.Update(table);
		}

		private static void ShowTable() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Diaplay Inventory Data Using AutoLogDAL library version 3");

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
