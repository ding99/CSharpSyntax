using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with type conversions *****");

			short num1 = 9, num2 = 10;
			Console.WriteLine("{0} + {1} = {2}", num1, num2, Add(num1, num2));
		}

		static int Add(int x, int y) { return x + y; }
	}
}
