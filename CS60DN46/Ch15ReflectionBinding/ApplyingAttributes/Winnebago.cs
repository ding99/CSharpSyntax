using AttributedCarLibrary;

namespace ApplyingAttributes {
	[VehicleDescription("A very long, slow, but feature-rich auto")]
	public class Winnebago {

		//Ulong types don't jibe with the CLS. A compiler warning
		public ulong notCompliant;

		[VehicleDescription("My rocking CD player")]
		public void PlayMusic(bool On) {
			System.Console.WriteLine($"Radio {On}");
		}
	}
}
