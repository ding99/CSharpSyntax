namespace AttributedCarLibrary {
	public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string description) {
            Description = description;
		}
        public VehicleDescriptionAttribute() { }
    }
}
