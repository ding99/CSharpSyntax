using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsings {
	class Program {
		static void Main() {
			Console.WriteLine("Please enter an input :");
			int a = 0;
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
