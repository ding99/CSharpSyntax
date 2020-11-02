using System;

namespace CMethod {
	class Switcher {
		public void ExamingSwitch() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Examine Switch");

			Dsp("ABD");
			Dsp("ABG");
			Dsp("FDASDFSAF");
			Console.ResetColor();
		}

		private void Dsp(string src) {
			switch (src) {
				case "ABC": Console.WriteLine("Sunday"); break;
				case "ABD": Console.WriteLine("Monday"); break;
				case "ABE": Console.WriteLine("Tuesday"); break;
				case "ABF": Console.WriteLine("Wednesday"); break;
				case "ABG": Console.WriteLine("Thursday"); break;
				case "ABH": Console.WriteLine("Friday"); break;
				default: Console.WriteLine("Saturday"); break;
			}
		}
	}
}
