using System.Windows.Forms;

namespace CarLibrary {
	public class MiniVan : Car {
		public MiniVan() { }
		public MiniVan(string name, int max, int speed) : base(name, max, speed) { }

		public override void TurboBoost() {
			egnState = EngineState.engineDead;
			MessageBox.Show("Eek!", "Your engine block exploded!");
		}
	}
}
