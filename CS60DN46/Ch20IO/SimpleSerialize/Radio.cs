using System;
using System.Xml.Serialization;

namespace SimpleSerialize {
	[Serializable]
	public class Radio {
		public bool hasTweeters;
		[XmlAttribute]
		public bool hasSubWoofers;
		public double[] stationPresets;

		[NonSerialized]
		public string radioID = "XF-552RR6";
	}
}
