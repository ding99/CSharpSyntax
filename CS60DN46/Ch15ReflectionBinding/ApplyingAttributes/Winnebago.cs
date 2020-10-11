using AttributedCarLibrary;

namespace ApplyingAttributes {
	[VehicleDescription("A very long, slow, but feature-rich auto")]
	class Winnebago {

		[VehicleDescription("My rocking CD player")]
		public void PlayMusic(bool On) {
			System.Console.WriteLine($"Radio {On}");
		}
	}
}
