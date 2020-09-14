using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFinalize {
	class MyResourceWrapper {
		// Compile-time error!
		~MyResourceWrapper() {
			//clean up unmanaged resources here
			Console.Beep();
		}
	}
}
