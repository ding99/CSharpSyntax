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
			nl.ExceptionMessage();

			Examine exam = new Examine();
			exam.Interpolation();
			exam.ExamineStruct();

			CDecimal dec = new CDecimal();
			dec.MoneyDivision();

			Console.ResetColor();
        }
    }
}
