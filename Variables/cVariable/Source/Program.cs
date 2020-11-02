using System;

namespace CVariable {
	class Program {
        static void Main(string[] args) {
            Console.WriteLine("== start");
            bool ret = true;

			Console.ForegroundColor = ConsoleColor.Yellow;
			Vari v = new Vari();
			ret = v.bytedef();
			ret = v.rows();
			//ret = v.toFloat();
			ret = Vari.toFloat();
			//v.sel();
			//v.valuable();

			//Console.ForegroundColor = ConsoleColor.Cyan;
			//ret = new Marks().TestMark();

			//Console.ForegroundColor = ConsoleColor.DarkYellow;
			//ret = new NullAble().TestValue();

			//Console.ForegroundColor = ConsoleColor.DarkCyan;
			//Examine exam = new Examine();
			//         exam.Interpolation();
			//         exam.ExamineStruct();

			Console.ResetColor();
            Console.WriteLine("== end (" + (ret ? "success)" : "failuer)"));
        }
    }
}
