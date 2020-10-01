using System;
using System.ComponentModel;
using AttributedCarLibrary;

namespace ApplyingAttributes {
	[Serializable]
	[VehicleDescription(Description = "My rocking Harley")]
	public class Motorcycle {
		[NonSerialized]
		float weightOfCurrentPassengers;
		//These fields are still serializeable
		bool hasRadioSystem;
		bool hasHeadSet;
		bool hasSissyBar;
	}
}
