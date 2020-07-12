using System;
using System.Collections.Generic;

namespace cList {
	public class BData {
		public string name;
		public int value;
		public BData() {
			name = String.Empty;
			value = 0;
		}
	}

	public class checkNew {
		private BData DSingle;
		private List<BData> DList;

		public checkNew() {
			DSingle = new BData();
			DList = new List<BData>();
		}

		public void startTest() {

			BData b1 = new BData() { name = "Firster", value = 111 };
			Console.WriteLine("b1 [" + b1.name + ", " + b1.value + "]");

			List<BData> list1 = new List<BData>() { b1, new BData() { name = "Secondr", value = 222 } };
			Console.WriteLine("-- list1 " + list1.Count);
			foreach(BData b in list1)
				Console.WriteLine("   " + b.name + ", " + b.value);

			list1.Add(new BData() { name = "Thirder", value = 333 });
			Console.WriteLine("-- list1 " + list1.Count);
			foreach(BData b in list1)
				Console.WriteLine("   " + b.name + ", " + b.value);
		}

		public void which() {
			DList.Add(new BData() { name = "student_1", value = 11 });
			DList.Add(new BData() { name = "student_2", value = 12 });
			DList.Add(new BData() { name = "student_3", value = 13 });

			Console.WriteLine("=== list (" + this.DList.Count + ")");
			foreach(BData b in this.DList)
				Console.WriteLine(b.name + " / " + b.value);

			Console.WriteLine("--- find second");
			foreach(BData b in this.DList)
				if(b == this.DList[1])
					Console.WriteLine("- found : " + b.name + " / " + b.value);

		}

		public void vari() {
			List<string> ls = new List<string>();
			string s = String.Empty;

			s = "AAAAAA";
			ls.Add(s);
			s = "BBBBBB";
			ls.Add(s);
			s = "CCCCCC";
			ls.Add(s);

			foreach(string l in ls)
				Console.WriteLine(l);

			Console.WriteLine();
			Console.WriteLine("source [" + s + "]");
		}

		private void dsp(int max) {
			Console.WriteLine("-- max " + max);
			for(int i = 0; i < max; i++)
				Console.WriteLine("  " + i);
			Console.WriteLine();
		}
		public void all() {
			dsp(5);
			dsp(0);
			dsp(-1);
		}
	}
}
