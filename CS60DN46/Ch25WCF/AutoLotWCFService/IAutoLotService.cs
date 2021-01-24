using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AutoLotDAL;

namespace AutoLotWCFService {
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IAutoLotService {

		[OperationContract]
		void InsertCar(int id, string make, string color, string petname);

		[OperationContract(Name = "InsertCarWithDetails")]
		void InsertCar(InventoryRecord car);

		[OperationContract]
		InventoryRecord[] GetInventory();
	}


	// Use a data contract as illustrated in the sample below to add composite types to service operations.
	[DataContract]
	public class InventoryRecord {

		[DataMember]
		public int ID;

		[DataMember]
		public string Make;

		[DataMember]
		public string Color;

		[DataMember]
		public string PetName;
	}
}
