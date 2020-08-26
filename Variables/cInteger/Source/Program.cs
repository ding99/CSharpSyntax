using System;

namespace cInt
{

	class Program {
        static void Main() {
            Console.WriteLine("== Start");

			Source.CheckInt test = new Source.CheckInt();
			test.shift();
			test.max();

			new CheckDecimal().test();

			Console.WriteLine("== End");
        }
    }
}
