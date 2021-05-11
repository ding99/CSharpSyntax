using System;

namespace CDelegate {

	class Entrance{
		static void Main() {
			Console.WriteLine("== Delegate Examination Start");

            Delegator delegator = new Delegator();
			delegator.Start();

			MultiDelegate md = new MultiDelegate();
			md.Start();

			ExamineInvoke iv = new ExamineInvoke();
			iv.Start();

			Predicator pred = new Predicator();
			pred.Start();

			Console.ResetColor();
			Console.WriteLine("== End");
        }
    }
}
