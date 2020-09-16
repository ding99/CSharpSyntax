namespace CarLibrary {
	public enum EngineState {  engineAlive, engineDead }

    public abstract class Car {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState egnState = EngineState.engineAlive;
        public EngineState EngineState { get { return egnState; } }
        public abstract void TurboBoost();

        public Car() { }
        public Car(string name, int max, int speed) { Name = name; MaxSpeed = max; Speed = speed; }
    }
}
