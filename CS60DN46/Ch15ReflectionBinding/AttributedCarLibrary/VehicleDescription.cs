namespace AttributedCarLibrary {
	public sealed class VehicleDescription : System.Attribute
    {
        public string Description { get; set; }
        public VehicleDescription(string description) {
            Description = description;
		}
        public VehicleDescription() { }
    }
}
