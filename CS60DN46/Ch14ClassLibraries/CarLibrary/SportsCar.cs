using System.Windows.Forms;

namespace CarLibrary {
	public class SportsCar : Car {
		public SportsCar() { }
		public SportsCar(string name, int max, int speed) : base(name, max, speed) { }
		public override void TurboBoost() {
			MessageBox.Show("Ramming.V2.0.0.2 speed", "Faster is better...");
		}
	}
}
