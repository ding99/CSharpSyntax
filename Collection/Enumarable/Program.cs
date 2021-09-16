using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumarable {
	class Program {
		static void Main() {

			Console.WriteLine("== Start");

			Existence e = new Existence();
			e.ExistAny();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
