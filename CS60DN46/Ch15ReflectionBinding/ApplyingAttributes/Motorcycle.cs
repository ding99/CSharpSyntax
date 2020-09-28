using System;

namespace ApplyingAttributes {
	[Serializable]
	public class Motorcycle {
		[NonSerialized]
		float weightOfCurrentPassengers;
		//These fields are still serializeable
		bool hasRadioSystem;
		bool hasHeadSet;
		bool hasSissyBar;
	}
}
