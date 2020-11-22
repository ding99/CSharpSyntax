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
			DelRows();
			ResetColor();
		}

		private static void DelRows() {
			ForegroundColor = ConsoleColor.DarkYellow;
			WriteLine("=> Delete Records Using AutoLogDAL library");

			var table = new AutoLotDataSet.InventoryDataTable();
			var adapter = new InventoryTableAdapter();
			adapter.Fill(table);

			DelRecords(table, adapter);
			table.Clear();
			adapter.Fill(table);
			PrintInventory(table);
		}

		private static void DelRecords(AutoLotDataSet.InventoryDataTable table, InventoryTableAdapter adapter) {
			try {
				AutoLotDataSet.InventoryRow row = table.FindByCarId(14);
				adapter.Delete(row.CarId, row.Make, row.Color, row.PetName);
				row = table.FindByCarId(13);
				adapter.Delete(row.CarId, row.Make, row.Color, row.PetName);
			}
			catch (Exception ex) { WriteLine(ex.Message); }
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
