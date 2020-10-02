using AttributedCarLibrary;

namespace ApplyingAttributes {
	[VehicleDescription("A very long, slow, but feature-rich auto")]
	class Winnebago {

		[VehicleDescription(Description = "Setup radio")]
		public void PlayMusic(bool On) {
			System.Console.WriteLine($"Radio {On}");
		}
	}
}
