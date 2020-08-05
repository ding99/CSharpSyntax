using System;

namespace NullableTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Nullable Data *****");

			NullableData();
			NullConditionalOpe();

			Console.ResetColor();
		}

		static void NullConditionalOpe()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			TesterMethod(new string[] { "First Row", "Second Row" });
			TesterMethod(null);
		}
		static void TesterMethod(string[] args)
		{
			Console.WriteLine($"You sent me {args?.Length ?? 0} argument.");
		}

		static void NullableData()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			DatabaseReader dr = new DatabaseReader();

			int? i = dr.GetIntFromDatabase();
			if (i.HasValue) Console.WriteLine($"Value of 'i' is {i.Value}");
			else Console.WriteLine("Value of 'i' is undefined.");

			bool? b = dr.GetBoolFromDatabse();
			if(b != null)
				Console.WriteLine($"Value of 'b' is {b.Value}");
			else Console.WriteLine("Value of 'b' is undefined.");
		}

		class DatabaseReader
		{
			public int? numericValue = null;
			public bool? boolValue = true;
			public int? GetIntFromDatabase() { return numericValue; }
			public bool? GetBoolFromDatabse() { return boolValue; }
	}
}
}
