using System.ComponentModel.DataAnnotations;

namespace AutoLotDAL.Models {
	public partial class CreditRisk {
		[Key]
		public int CustId { get; set; }

		[StringLength(50)]
		public string FirstName { get; set; }

		[StringLength(50)]
		public string LastName { get; set; }
	}
}
