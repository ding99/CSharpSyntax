using System;

namespace CProperty {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=== start");
            
            new PV2().test();
            new PV3().test();

            Console.ResetColor();
            Console.WriteLine("=== end");
        }
    }

}
