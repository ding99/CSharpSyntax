using System;

namespace List {
	class Program {
		static void Main() {
			Console.WriteLine("== Start Examining List");
			ExamineList examer = new ExamineList();
			examer.Sort();

			First f = new First();
			f.Start();

			CheckNew cn = new CheckNew();
			cn.startTest();
			cn.which();
			cn.vari();
			cn.all();


			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
