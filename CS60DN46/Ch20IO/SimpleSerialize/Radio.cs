using System;

namespace SimpleSerialize {
	[Serializable]
	class Radio {
		public bool hasTweeters;
		public bool hasSubWoofers;
		public double[] stationPresets;

		[NonSerialized]
		public string radioID = "XF-552RR6";
	}
}
