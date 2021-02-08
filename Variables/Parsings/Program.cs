using System;

namespace Parsings {
	class Program {
		static void Main() {
			int a = 0;

			Console.Write("Please enter an input value :");
			try {
				a = Convert.ToInt32(Console.ReadLine());
				//"size=45000"
			}
			catch(Exception e) {
				Console.WriteLine($"Error: {e.Message}");
			}

			Console.WriteLine($"Input value is : {a}");
			Console.WriteLine($"The output is : {1}");
		}
	}
}
