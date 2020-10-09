using System;

namespace AttributeAppl {
	[AttributeUsage(AttributeTargets.All)]
	public class HelpAttribute : Attribute {
		public readonly string Url;
		public string Topic { get; set; }
		public HelpAttribute(string url) { Url = url; }
	} 
}
