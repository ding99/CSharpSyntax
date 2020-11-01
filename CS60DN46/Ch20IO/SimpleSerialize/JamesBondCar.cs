using System;
using System.Xml.Serialization;

namespace SimpleSerialize {
	[Serializable, XmlRoot(Namespace = "http://www.MyCompany.com")]
	public class JamesBondCar : Car {
		[XmlAttribute]
		public bool canFly;
		public bool canSubmerge;
	}
}
