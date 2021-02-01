using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL.Models {
	public partial class Inventory {
		public override string ToString() {
			return  $"{this.PetName ?? "**No Name**"} is a {this.Make} {this.Color} with ID {this.CarId}.";
		}

		[NotMapped]
		public string MakeColor => $"{Make} ({Color})";
	}
}
