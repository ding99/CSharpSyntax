using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL.Models {
	public partial class Inventory {
		public override string ToString() {
			return  $"{this.PetName ?? "**No Name**"} is a {this.Make} {this.Color} with ID {this.CarId}.";
		}

		[NotMapped]
		public string MakeColor => $"{Make} + ({Color})";
	}
}
