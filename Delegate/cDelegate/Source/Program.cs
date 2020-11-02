using System;

namespace CDelegate {

	class Entrance{
		static void Main(string[] args) {
			System.Console.WriteLine("== Start");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Delegator delegator = new Delegator();
            delegator.dele();
            delegator.actn();
            delegator.act2();
            delegator.func();

            Console.ForegroundColor = ConsoleColor.Cyan;
			MultiDelegate md = new MultiDelegate();
			//md.TestSingle();
			md.TestMulti();

			Invoke iv = new Invoke();
			iv.start();

			System.Console.WriteLine("== End");
        }
    }
}
