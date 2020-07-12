using System;

namespace cGeneric {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("== Start");

			CheckBase gene = new CheckBase();
			gene.testbase();

			CheckSwap swap = new CheckSwap();
			swap.testswap();

			CheckDele dele = new CheckDele();
            dele.testdele();

            Console.WriteLine("== End");
        }
    }
}
