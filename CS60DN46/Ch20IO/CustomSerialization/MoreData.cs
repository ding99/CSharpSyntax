using System;
using System.Runtime.Serialization;

namespace CustomSerialization {
	[Serializable]
	class MoreData {
		private string dataItemOne = "First data block";
		private string dataItemTwo = "More data";

		[OnSerializing]
		private void OnSerializing (StreamingContext context) {
			dataItemOne = dataItemOne.ToUpper();
			dataItemTwo = dataItemTwo.ToUpper();
		}

		private void OnDeserialized(StreamingContext context) {
			dataItemOne = dataItemOne.ToLower();
			dataItemTwo = dataItemTwo.ToLower();
		}
	}
}
