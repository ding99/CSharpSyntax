using cGeneric.Source;
using System;

namespace cGeneric {
    class Program {
        static void Main() {
            Console.WriteLine("== Start");

			CheckBase gene = new CheckBase();
			gene.testbase();

			CheckSwap swap = new CheckSwap();
			swap.testswap();

			CheckDele dele = new CheckDele();
            dele.testdele();

            new PracticeGeneric().Start();

            Console.ResetColor();
            Console.WriteLine("== End");
        }
    }
}
