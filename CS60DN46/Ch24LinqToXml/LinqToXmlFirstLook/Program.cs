using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinqToXmlFirstLook {
	class Program {
		static void Main() {
			Console.WriteLine("***** Linq to XML First Look *****");

			UseDOM();

			Console.ResetColor();
		}

		private static void UseDOM() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Build XML Doc with DOM");
		}
	}
}
