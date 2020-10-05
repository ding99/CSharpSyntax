using System;

namespace DebugAttribute {

	[AttributeUsage(AttributeTargets.Class|AttributeTargets.Constructor|AttributeTargets.Field|AttributeTargets.Method|AttributeTargets.Property,AllowMultiple =true)]
	class DebugInfoAttribute : Attribute {
		public DebugInfoAttribute(int bg, string dev, string review) {
			BugNo = bg; Developer = dev; LastReview = review;
		}

		public int BugNo { get; }
		public string Developer { get; }
		public string LastReview { get; }
		public string Message { get; set; }
	}
}
