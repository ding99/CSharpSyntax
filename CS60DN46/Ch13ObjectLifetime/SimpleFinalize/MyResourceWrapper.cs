using System;

namespace SimpleFinalize {
	class MyResourceWrapper {
		// Compile-time error!
		~MyResourceWrapper() {
			//clean up unmanaged resources here
			Console.Beep();
		}
	}
}
