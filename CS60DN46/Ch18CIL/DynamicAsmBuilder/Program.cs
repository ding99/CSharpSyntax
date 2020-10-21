using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace DynamicAsmBuilder {
	class Program {
		static void Main() {
			Console.WriteLine("***** Dynamic Assembly Builder *****");
			AppDomain domain = Thread.GetDomain();
			CreateMyAsm(domain);
			Console.ResetColor();
		}

		private static void CreateMyAsm(AppDomain curAppDomain) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Create an assembly");
		}
	}
}
