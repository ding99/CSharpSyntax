using System;

namespace Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			BasicStringFunctionality();
			VerBatimStrings();
		}

		private static void VerBatimStrings()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine("=> Verbatim Strings");
			Console.WriteLine(@"C:\MyApp\bin\Debug");
			string myLongString = @"This is a very
	very
		very
			long string";
			Console.WriteLine(myLongString);
			Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
			Console.WriteLine();

			Console.ResetColor();
		}

		private static void BasicStringFunctionality()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine("=> Basic String Functionality");
			string firstName = "Freddy";
			Console.WriteLine("Value of firstName: {0}", firstName);
			Console.WriteLine("firstName has {0} characters.", firstName.Length);
			Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
			Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
			Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
			Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
			Console.WriteLine("Value of firstName: {0}", firstName);
			Console.WriteLine();

			Console.ResetColor();
		}
	}
}
