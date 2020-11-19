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

			var inventoryTable = new DataTable("Inventory");
			inventoryTable.Columns.AddRange(new[] { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });
		}

		private static void PrintDataSet(DataSet s) {
			WriteLine("-> Print DataSet");
			var props = s.ExtendedProperties;
			WriteLine($"Properties (size {props.Count}):");
			foreach (var a in props)
				if(a is DictionaryEntry)
					WriteLine($"  <{((DictionaryEntry)a).Key}> : <{((DictionaryEntry)a).Value}> ");
		}
	}
}
