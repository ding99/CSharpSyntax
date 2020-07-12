using System;
using System.IO;
using System.Text;

namespace cStream {

	public class rewardline {
		StreamReader st;
		public rewardline(string iname) {
			this.st = new StreamReader(iname, Encoding.Unicode);
		}

		public bool reRead() {
			string line = String.Empty;
			int stmp;

			while(true){
				Console.Write("<" + (stmp = this.st.Peek()).ToString("x2") + "> ");
				if(stmp == -1) { Console.WriteLine(" -END-"); break; }
				line = this.st.ReadLine();
				Console.WriteLine(line);
			}
			return true;
		}

	}

	class Program {
		static void Main(string[] args) {

			Console.WriteLine("start");

			string testfile = @"C:\test\testuns\ext\complex_short.uns";
			rewardline rl = new rewardline(args.Length == 0 ? testfile : args[0]);

			bool ret = rl.reRead();
			Console.WriteLine(ret ? "succeeded" : "failed");

			Console.ReadLine();
		}
	}
}
