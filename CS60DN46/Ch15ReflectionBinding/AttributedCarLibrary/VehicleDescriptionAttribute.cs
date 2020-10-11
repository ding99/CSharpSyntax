using System;

namespace AttributedCarLibrary {
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Method,Inherited =false)]
	public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string description) {
            Description = description;
		}
        public VehicleDescriptionAttribute() { }
    }
}
