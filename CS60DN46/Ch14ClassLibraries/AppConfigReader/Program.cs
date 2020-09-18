using System;
using System.Configuration;

namespace AppConfigReader {
	class Program {
		static void Main() {
			Console.WriteLine("***** Examine configuration namespace *****");
			Reader();
			Console.ResetColor();
		}

		static void Reader() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Reading <appSettings> Data");

			AppSettingsReader reader = new AppSettingsReader();
			int numbOfTimes = (int)reader.GetValue("RepeatCount",typeof(int));
			string color = (string)reader.GetValue("TextColor", typeof(string));

			Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
			for(int i = 0; i < numbOfTimes; i++)
				Console.WriteLine("Howdy!");
		}
	}
}
