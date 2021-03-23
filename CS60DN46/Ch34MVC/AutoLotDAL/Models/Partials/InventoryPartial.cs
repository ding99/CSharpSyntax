using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AutoLotDAL.Models.MetaData;

namespace AutoLotDAL.Models {
	[MetadataType(typeof(InventoryMetaData))]
	public partial class Inventory {
		public override string ToString() {
			return  $"{this.PetName ?? "**No Name**"} is a {this.Make} {this.Color} with ID {this.CarId}.";
		}

		[NotMapped]
		public string MakeColor => $"{Make} ({Color})";
	}
}
