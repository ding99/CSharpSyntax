using System;

namespace CDelegate {

	class Entrance{
		static void Main() {
			Console.WriteLine("== Delegate Examination Start");

            Delegator delegator = new Delegator();
			delegator.Start();

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
