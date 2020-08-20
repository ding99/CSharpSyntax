using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithNonGenericCollections
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Non-Generic Collection *****");
			ArrayList();
			Console.ResetColor();
		}

		static void ArrayList()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> ArrayList");

			ArrayList strArray = new ArrayList();
			strArray.AddRange(new string[] {"First","Second","Third"});
			Console.WriteLine($"This colllection has {strArray.Count} items");

			strArray.Add("Fourth!");
			Console.WriteLine($"This colllection has {strArray.Count} items");
			foreach (string s in strArray)
				Console.Write($"Entry: {s}, ");
			Console.WriteLine();

		}
	}
}
