using System;

namespace CCharact {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("== start");

			Charct ct = new Charct();
			ct.dsp(); //To double check: exception here
			ct.oddParity();
			ct.charUnic();
			ct.char2byte();
			ct.value();

			Console.WriteLine("size of byte " + sizeof(byte));

			new ConstTest().test();

            Console.WriteLine("== end");
        }
    }
}
