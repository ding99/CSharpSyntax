using System;
using System.Text;

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
			FunWithStringBuilder();
			StringInterpolation();

			Console.ResetColor();
		}

		private static void StringInterpolation()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine("=> String Interpolatoin");
			int age = 4;
			string name = "Soren";
			string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
			string greeting2 = $"Hello {name} you are {age} years old.";
			Console.WriteLine(greeting);
			Console.WriteLine(greeting2);
			Console.WriteLine();
		}

		private static void FunWithStringBuilder()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine("=> Using the StringBuilder:");
			StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
			sb.Append("\n");
			sb.AppendLine("Half Life");
			sb.AppendLine("Morrowind");
			sb.AppendLine("Deus Ex" + "2");
			sb.AppendLine("System Shock");
			Console.WriteLine(sb.ToString());

			sb.Replace("2", " invisible War");
			Console.WriteLine(sb.ToString());
			Console.WriteLine("Its length: {0}", sb.ToString().Length);

			Console.WriteLine("sb has {0} chars.", sb.Length);
			Console.WriteLine();
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

			string s2 = "The first time";
			Console.WriteLine("s2 = {0}", s2);
			s2 = "The second time";
			Console.WriteLine("s2 = {0}", s2); //for ildasm.exe
			Console.WriteLine();
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

			Console.WriteLine("Insert AAA to firstName: {0}", firstName.Insert(3, "AAA"));
			Console.WriteLine("PadLeft AAA to firstName: {0}", firstName.PadLeft(16, 'A'));
			Console.WriteLine("PadRight AAA to firstName: {0}", firstName.PadRight(16, 'A'));

			Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
			Console.WriteLine("Value of firstName: {0}", firstName);

			Console.WriteLine("Compare firstName to \"Freddy\": {0}", firstName.CompareTo("Freddy"));
			Console.WriteLine("Compare firstName to \"redd\": {0}", firstName.CompareTo("redd"));
			Console.WriteLine("Compare firstName to \"AAA\": {0}", firstName.CompareTo("AAA"));
			Console.WriteLine();
		}
	}
}
