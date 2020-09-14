using System;

namespace SimpleFinalize {
	class MyResourceWrapper {
		~MyResourceWrapper() {
			//clean up unmanaged resources here
			Console.Beep();
		}
	}
}
