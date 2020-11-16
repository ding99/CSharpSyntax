using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cClass {
	public class Class1 {
		public void Start1() { Console.WriteLine("Class 1"); }
	}
	class Class2 {
		public void Start() { Console.WriteLine("Class 2"); }
		class Class3 {
			public void Start() { Console.WriteLine("Class 3"); }
		}
	}
}

namespace NotCSLibrary {
	class Class4 {
		public void Start1() { Console.WriteLine("Class 4"); }
	}
}


namespace NotInCSLibrary {
	class Class5 {
		public void Start1() { Console.WriteLine("Class 5"); }
	}
}
