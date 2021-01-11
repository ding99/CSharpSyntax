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

			//Console.ForegroundColor = ConsoleColor.Cyan;
			//ret = new Marks().TestMark();

			//Console.ForegroundColor = ConsoleColor.DarkYellow;
			//ret = new NullAble().TestValue();

			//Console.ForegroundColor = ConsoleColor.DarkCyan;
			//Examine exam = new Examine();
			//         exam.Interpolation();
			//         exam.ExamineStruct();

			Console.ResetColor();
        }
    }
}
