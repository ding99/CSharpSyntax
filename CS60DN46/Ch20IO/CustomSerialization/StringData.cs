using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace CustomSerialization {
	[Serializable]
	class StringData : ISerializable {
		private string dataItemOne = "First data block";
		private string dataItemTwo = "More data";

		public StringData() {}
		protected StringData(SerializationInfo si, StreamingContext ctx) {
			dataItemOne = si.GetString("First_Item").ToLower();
			dataItemTwo = si.GetString("dataItemTwo").ToLower();
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext ctx) {
			info.AddValue("First_Item", dataItemOne.ToUpper());
			info.AddValue("dataItemTwo", dataItemTwo.ToUpper());
		}
	}
}
