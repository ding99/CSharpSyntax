using System;

namespace CDelegate {

	class Entrance{
		static void Main() {
			Console.WriteLine("== Delegate Examination Start");

            Delegator delegator = new Delegator();
			delegator.Start();

			MultiDelegate md = new MultiDelegate();
			md.Start();

			Invoke iv = new Invoke();
			iv.start();

			Console.ResetColor();
			Console.WriteLine("== End");
        }
    }
}
