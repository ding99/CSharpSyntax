using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSerialize {
	class Program {
		static void Main() {
			Console.WriteLine("***** Simple Serialization *****");
			Serialize();
			Console.ResetColor();
		}

		private static void Serialize() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Start to Serialize");
			JamesBondCar jb = new JamesBondCar();
		}
	}
}
