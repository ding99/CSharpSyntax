namespace AttributedCarLibrary {
	[VehicleDescription("A very long, slow, but feature-rich auto")]
	public class Winnebago {

		[VehicleDescription("My rocking CD player")]
		public void PlayMusic(bool On) {
			System.Console.WriteLine($"Radio {On}");
		}
	}
}
