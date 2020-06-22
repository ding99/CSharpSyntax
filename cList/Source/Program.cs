using cList.Source;
using System;

namespace cList {

    class Entrance {
        static void Main(string[] args) {

            Console.WriteLine("== start");

			//checkNew cn = new checkNew();
			//cn.startTest();
			//cn.which();
			//cn.vari();
			//cn.all();

			//checkIndex idx = new checkIndex();
			//idx.index();
			//idx.which();

			//NPV npv = new NPV();
			//npv.commonList();

			//chkJoin join = new chkJoin();
			//join.join();

			//checkArrayList arr = new checkArrayList();
			//arr.test();

			//Brief b = new Brief();
			////b.list();
			//b.less();

			new cLoop().LoopStart();

			Console.WriteLine("== end");
        }
    }
}
