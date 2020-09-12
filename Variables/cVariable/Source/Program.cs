using System;

namespace cVariable.Source {
	class Program {
        static void Main(string[] args) {
            Console.WriteLine("== start");
            bool ret = true;

            //Vari v = new Vari();
            //ret = v.bytedef();
            //ret = v.rows();
            //ret = v.toFloat();
            //v.sel();
            //v.valuable();

            //ret = new Marks().TestMark();

            //ret = new NullAble().TestValue();

            Examine exam = new Examine();
            exam.Interpolation();
            exam.ExamineStruct();

            Console.WriteLine("== end (" + (ret ? "success)" : "failuer)"));
        }
    }
}
