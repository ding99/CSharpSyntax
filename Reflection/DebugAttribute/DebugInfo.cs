using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugAttribute {
	class DebugInfo : Attribute {
		private int bugNo;
		private string developer;
		private string lastReview;

		public string message;

		public DebugInfo(int bg, string dev, string review) {
			bugNo = bg; developer = dev; lastReview = review;
		}
	}
}
