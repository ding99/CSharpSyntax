using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDelegate {
	public class Predicator {
		public Predicator() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
		}

		public void Start() {
			Console.WriteLine("-- Start Predicate examination");

			Uppercases();
		}

		private void Uppercases() {
			isUp("Hello Predicator!");
			isUp("HELLO PREDICATOR!");
		}

		private void isUp(string str) {
			Predicate<string> isUpper = s => s.Equals(s.ToUpper());
			Console.WriteLine($"[{str}] all uppercases? -> {isUpper(str)}");
		}
	}
}
