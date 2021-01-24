using AutoLotDAL.ConnectedLayer;
using System.Collections.Generic;
using System.Data;

namespace AutoLotWCFService {
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class AutoLotService : IAutoLotService {
		private const string ConnString = @"Data Source=(local);Initial Catalog=AutoLot;Integrated Security=True";

		public void InsertCar(int id, string make, string color, string petName) {
			InventoryDAL d = new InventoryDAL();
			d.OpenConnection(ConnString);
			d.InsertAuto(id, color, make, petName);
			d.CloseConnection();
		}

		public void InsertCar(InventoryRecord car) {
			InventoryDAL d = new InventoryDAL();
			d.OpenConnection(ConnString);
			d.InsertAuto(car.ID, car.Color, car.Make, car.PetName);
			d.CloseConnection();
		}

		public InventoryRecord[] GetInventory() {
			InventoryDAL d = new InventoryDAL();
			d.OpenConnection(ConnString);
			DataTable table = d.GetAllInventoryAsDataTable();
			d.CloseConnection();

			List<InventoryRecord> records = new List<InventoryRecord>();

			DataTableReader reader = table.CreateDataReader();
			while (reader.Read()) {
				InventoryRecord r = new InventoryRecord();
				r.ID = (int)reader["CarID"];
				r.Color = ((string)reader["Color"]);
				r.Make = ((string)reader["Make"]);
				r.PetName = ((string)reader["PetName"]);

				records.Add(r);
			}

			return (InventoryRecord[])records.ToArray();
		}
	}
}
