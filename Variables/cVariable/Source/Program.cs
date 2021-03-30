using System;

namespace CVariable {
	class Program {
        static void Main() {
            Console.WriteLine("== start");

			Console.ForegroundColor = ConsoleColor.Yellow;
			Variables v = new Variables();
			
			v.ByteDef();
			v.Rows();
			Variables.ToDouble();
			v.Select();
			v.Valuable();

			new Marks().TestMark();

			NullAble nl = new NullAble();
			nl.TestValue();

			Examine exam = new Examine();
			exam.Interpolation();
			exam.ExamineStruct();

			Console.ResetColor();
        }
    }
}
