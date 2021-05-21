using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL.Models {
	public partial class Order {
		public int OrderId { get; set; }
		public int CustId { get; set; }
		public int CarId { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual Inventory Car { get; set; }
	}
}
