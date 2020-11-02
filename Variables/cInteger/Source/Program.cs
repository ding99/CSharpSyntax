using System;

namespace CInt
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
			CRandom rand = new CRandom();
			rand.Start();

			Console.WriteLine("== End");
        }
    }
}
