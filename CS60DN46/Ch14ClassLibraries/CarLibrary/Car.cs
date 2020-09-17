using System.Windows.Forms;

namespace CarLibrary {
	public enum EngineState {  engineAlive, engineDead }

    public abstract class Car {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState egnState = EngineState.engineAlive;
        public EngineState EngineState { get { return egnState; } }
        public abstract void TurboBoost();

        public Car() { MessageBox.Show("CarLib Version 2.0"); }
        public Car(string name, int max, int speed) {
            MessageBox.Show("CarLib Version 2.0");
            Name = name; MaxSpeed = max; Speed = speed;
        }

        public void TurnOnRadio(bool musicOn, MusicMedia mm) {
            if (musicOn) MessageBox.Show($"Jamming {mm}");
            else MessageBox.Show("Quiet time...");
		}
    }
}
