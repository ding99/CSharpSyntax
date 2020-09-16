using System.Windows.Forms;

namespace CarLibrary {
	public class SportsCar : Car {
		public SportsCar() { }
		public SportsCar(string name, int max, int speed) : base(name, max, speed) { }
		public override void TurboBoost() {
			MessageBox.Show("Ramming speed", "Faster is better...");
		}
	}
}
