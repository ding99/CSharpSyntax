using System;

namespace DebugAttribute {

	[AttributeUsage(AttributeTargets.Class|AttributeTargets.Constructor|AttributeTargets.Field|AttributeTargets.Method|AttributeTargets.Property,AllowMultiple =true)]
	class DebugInfoAttribute : Attribute {
		private int bugNo;
		private string developer;
		private string lastReview;

		public string message;

		public DebugInfoAttribute(int bg, string dev, string review) {
			bugNo = bg; developer = dev; lastReview = review;
		}

		public int BugNo { get { return bugNo; } }
		public string Developer { get { return developer; } }
		public string LastReview { get { return lastReview; } }
		public string Message { get { return message; } set { message = value; } }
	}
}
