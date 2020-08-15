using System;

namespace ICloneableExample
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** A First Look at Interfaces *****");
			ExamineClone();
			Console.ResetColor();
		}

		static void ExamineClone()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> ICloneabel Interface");

			string myStr = "Hello";
			OperatingSystem unixOs = new OperatingSystem(PlatformID.Unix, new Version());
			System.Data.SqlClient.SqlConnection connect = new System.Data.SqlClient.SqlConnection();
			CloneMe(myStr);
			CloneMe(unixOs);
			CloneMe(connect);
		}

		private static void CloneMe(ICloneable c)
		{
			object theClone = c.Clone();
			Console.WriteLine($"Your clone is a: {theClone.GetType().Name}");
		}
	}
}
