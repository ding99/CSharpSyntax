using System;

namespace CList {

    class Entrance {
        static void Main(string[] args) {

            Console.WriteLine("== Start");

			//CheckNew cn = new CheckNew();
			//cn.startTest();
			//cn.which();
			//cn.vari();
			//cn.all();

			//CheckIndex idx = new CheckIndex();
			//idx.index();
			//idx.which();

			//NPV npv = new NPV();
			//npv.commonList();

			CheckJoin join = new CheckJoin();
			join.join();

			CheckArrayList arr = new CheckArrayList();
			arr.test();

			Brief b = new Brief();
			b.list();
			b.less();

			new CLoop().LoopStart();

			Console.WriteLine("== End");
        }
    }
}
