using System;
using System.Security.Cryptography;

namespace Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			BasicStringFunctionality();
			VerBatimStrings();
			StringEqulity();
			StringsAreImmutable();
		}

		private static void StringsAreImmutable()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;

			Console.WriteLine("=> Strings are immutable");
			string s1 = "This is my string";
			Console.WriteLine("s1 = {0}", s1);
			string upperString = s1.ToUpper();
			Console.WriteLine("upperString = {0}", upperString);
			Console.WriteLine("s1 = {0}", s1);
			Console.WriteLine();

			Console.ResetColor();
		}

		private static void StringEqulity()
		{
			Console.ForegroundColor = ConsoleColor.Blue;

			Console.WriteLine("=> String Equality");
			string s1 = "Hello!", s2 = "Yo!";
			Console.WriteLine("s1 = {0}", s1);
			Console.WriteLine("s2 = {0}", s2);
			Console.WriteLine();

			Console.WriteLine("s1 == s2: {0}", s1 == s2);
			Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
			Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
			Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
			Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
			Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
			Console.WriteLine("Yo! == s2: {0}", "Yo!" == s2);
			Console.WriteLine();

			Console.ResetColor();
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
