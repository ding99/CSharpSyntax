using System;

namespace SimpleSerialize {
	[Serializable]
	class Car {
		public Radio theRadio = new Radio();
		public bool isHatchBack;
	}
}
