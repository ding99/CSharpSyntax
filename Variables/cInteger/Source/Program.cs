using System;

namespace cInt
{

	class Program {
        static void Main() {
            Console.WriteLine("== Start");

			Console.ForegroundColor = ConsoleColor.Yellow;
			CheckInt test = new CheckInt();
			test.shift();
			test.max();

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			new CheckDecimal().Start();

			Console.ForegroundColor = ConsoleColor.Cyan;
			Random rand = new Random();
			rand.Start();

			Console.WriteLine("== End");
        }
    }
}
