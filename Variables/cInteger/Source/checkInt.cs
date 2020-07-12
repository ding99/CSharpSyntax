using System;
using cInt.Source;

namespace cInt {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("== Start");

			Source.Program test = new Source.Program();
			test.shift();
			test.max();

			new DecTest().test();

			Console.WriteLine("== End");
        }
    }
}
