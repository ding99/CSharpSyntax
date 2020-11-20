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
			SaveAndLoadAsXml(ds);
		}

		private static void SaveAndLoadAsXml(DataSet ds) {
			ForegroundColor = ConsoleColor.DarkCyan;
			string xmlfile = "carsDataSet.xml";
			WriteLine($"=> Save and Load xml file. File name <{xmlfile}>");

			WriteLine("- write xml");
			ds.WriteXml(xmlfile);
			ds.WriteXmlSchema("carDataSet.xsd");

			ds.Clear();

			WriteLine("- read xml");
			ds.ReadXml(xmlfile);
		}

		private static void PrintDataSet(DataSet s) {
			WriteLine($"-> Print DataSet <{s.DataSetName}>");
			var props = s.ExtendedProperties;
			WriteLine($"Properties (size {props.Count}):");
			foreach (DictionaryEntry a in props)
					WriteLine($"  <{a.Key}> : <{a.Value}> ");

			int n = 1;
			foreach(DataTable t in s.Tables) {
				ForegroundColor = ConsoleColor.Yellow;
				WriteLine($"-- {t.TableName} Table:");

				for (var col = 0; col < t.Columns.Count; col++)
					Write($"{t.Columns[col].ColumnName}\t");
				WriteLine("\n-----------------------------------");
				for(var row = 0; row < t.Rows.Count; row++) {
					for (var col = 0; col < t.Columns.Count; col++)
						Write($"{t.Rows[row][col]}\t");
					WriteLine();
				}
				WriteLine("-----------------------------------");

				PrintTable(t);
				t.WriteXml("table_" + n++ + ".xml");
			}
		}

		private static void PrintTable(DataTable t) {
			ForegroundColor = ConsoleColor.DarkYellow;

			DataTableReader reader = t.CreateDataReader();
			while (reader.Read()) {
				for (var i = 0; i < reader.FieldCount; i++)
					Write($"{reader.GetValue(i).ToString().Trim()}\t");
				WriteLine();
			}
			reader.Close();
		}

		private static void FillDataSet(DataSet s) {
			WriteLine("-> Fill DataSet");

			#region table 01
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
			#endregion

			#region table 02
			#region columns
			var carIDColumn2 = new DataColumn("CarID", typeof(int)) {
				Caption = "Car2 ID",
				ReadOnly = true,
				AllowDBNull = false,
				Unique = true,
				AutoIncrement = true,
				AutoIncrementSeed = 1,
				AutoIncrementStep = 1
			};

			var carMakeColumn2 = new DataColumn("Make", typeof(string));
			var carColorColumn2 = new DataColumn("Color", typeof(string));
			var carPetNameColumn2 = new DataColumn("PetName", typeof(string)) {
				Caption = "Pet Name"
			};
			#endregion

			#region table
			var vehicleTable = new DataTable("Vehicle");
			vehicleTable.Columns.AddRange(new[] { carIDColumn2, carMakeColumn2, carColorColumn2, carPetNameColumn2 });
			vehicleTable.PrimaryKey = new[] { vehicleTable.Columns[0] };
			#endregion

			#region rows
			row = vehicleTable.NewRow();
			row["Make"] = "Yuhe";
			row["Color"] = "Green";
			row["PetName"] = "Fast";
			vehicleTable.Rows.Add(row);

			row = vehicleTable.NewRow();
			row["Make"] = "Yamaha";
			row["Color"] = "Blue";
			row["PetName"] = "Flying";
			vehicleTable.Rows.Add(row);

			row = vehicleTable.NewRow();
			row["Make"] = "Qingqi";
			row["Color"] = "White";
			row["PetName"] = "Fish";
			vehicleTable.Rows.Add(row);
			#endregion rows

			s.Tables.Add(vehicleTable);
			#endregion
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
