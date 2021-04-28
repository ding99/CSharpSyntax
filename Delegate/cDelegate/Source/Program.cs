using System;

namespace CDelegate {

	class Entrance{
		static void Main(string[] args) {
			Console.WriteLine("== Start");

            Delegator delegator = new Delegator();
			delegator.Start();
            //delegator.dele();
            //delegator.actn();
            //delegator.act2();
            //delegator.func();

            Console.ForegroundColor = ConsoleColor.Cyan;
			MultiDelegate md = new MultiDelegate();
			//md.TestSingle();
			md.TestMulti();

			Invoke iv = new Invoke();
			iv.start();

			Console.ResetColor();
			Console.WriteLine("== End");
        }
    }
}
