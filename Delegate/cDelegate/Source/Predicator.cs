using System;
using System.Collections.Generic;

namespace CDelegate {
	public class Predicator {
		public Predicator() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
		}

		public void Start() {
			Console.WriteLine("Start Predicate examination");

			Uppercases();
			Filter();
		}

		private void Uppercases() {
			Console.WriteLine("-- Judge uppercases string");
			isUp("Hello Predicator!");
			isUp("HELLO PREDICATOR!");
		}

		private void isUp(string str) {
			Predicate<string> isUpper = s => s.Equals(s.ToUpper());
			Console.WriteLine($"[{str}] all uppercases? -> {isUpper(str)}");
		}

		private void Filter() {
			Console.WriteLine("-- Integer filter");
			var data = new List<int> { 1, -2, 3, 0, 2, -1 };
			Console.WriteLine($"original ({data.Count}): {string.Join(",", data)}");

			var predicate = new Predicate<int>(x => x > 0);
			var filtered = data.FindAll(predicate);
			Console.WriteLine($"filtered ({filtered.Count}): {string.Join(",", filtered)}");
		}
	}
}
