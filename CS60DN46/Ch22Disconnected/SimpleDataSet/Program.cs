using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using static System.Console;

namespace SimpleDataSet {
	class Program {
		static void Main() {
			WriteLine("***** Fun with DataSets *****");
			ManipulateDataRowState();
			CreateData();

			ResetColor();
		}

		private static void CreateData() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Create DataSet");

			var ds = new DataSet("Car Inventory");

			ds.ExtendedProperties["TimeStamp"] = DateTime.Now;
			ds.ExtendedProperties["DataSetID"] = Guid.NewGuid();
			ds.ExtendedProperties["Company"] = "Hot Tub Super Store";

			FillDataSet(ds);
			PrintDataSet(ds);
		}

		private static void FillDataSet(DataSet s) {
			WriteLine("-> Fill DataSet");
			#region columns
			var carIDColumn = new DataColumn("CarID", typeof(int)) {
				Caption = "Car ID",
				ReadOnly = true,
				AllowDBNull = false,
				Unique = true,
				AutoIncrement = true,
				AutoIncrementSeed = 1,
				AutoIncrementStep = 1
			};

			var carMakeColumn = new DataColumn("Make", typeof(string));
			var carColorColumn = new DataColumn("Color", typeof(string));
			var carPetNameColumn = new DataColumn("PetName", typeof(string)){
				Caption = "Pet Name"
			};
			#endregion

			#region table
			var inventoryTable = new DataTable("Inventory");
			inventoryTable.Columns.AddRange(new[] { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });
			inventoryTable.PrimaryKey = new[] { inventoryTable.Columns[0] };
			#endregion

			#region rows
			DataRow row = inventoryTable.NewRow();
			row["Make"] = "BMW";
			row["Color"] = "Black";
			row["PetName"] = "Hamlet";
			inventoryTable.Rows.Add(row);

			row = inventoryTable.NewRow();
			row["Make"] = "Saab";
			row["Color"] = "Red";
			row["PetName"] = "Sea Breeze";
			inventoryTable.Rows.Add(row);
			#endregion rows

			s.Tables.Add(inventoryTable);
		}

		private static void PrintDataSet(DataSet s) {
			WriteLine("-> Print DataSet");
			var props = s.ExtendedProperties;
			WriteLine($"Properties (size {props.Count}):");
			foreach (var a in props)
				if(a is DictionaryEntry)
					WriteLine($"  <{((DictionaryEntry)a).Key}> : <{((DictionaryEntry)a).Value}> ");
		}

		private static void ManipulateDataRowState() {
			ForegroundColor = ConsoleColor.Cyan;
			WriteLine("=> Manipulate DataRowState");

			var temp = new DataTable("Temp");
			temp.Columns.Add(new DataColumn("TempColumn", typeof(int)));

			var row = temp.NewRow();
			WriteLine($"After calling NewRow(): {row.RowState}");

			temp.Rows.Add(row);
			WriteLine($"After calling Rows.Add(): {row.RowState}");

			row["TempColumn"] = 10;
			WriteLine($"After first assignment: {row.RowState}");

			temp.AcceptChanges();
			WriteLine($"After calling AcceptChanges: {row.RowState}");

			row["TempColumn"] = 11;
			WriteLine($"After second assignment: {row.RowState}");

			temp.Rows[0].Delete();
			WriteLine($"After calling Delete: {row.RowState}");
		}
	}
}
