using System;

namespace cDllLoad {
	public class Loader {
		public Loader() {
		}

		public void loadLib() {
			string msg = "Top_Message";
			cDllLibm.LibTransfer lt = new cDllLibm.LibTransfer();
			lt.dspmid(msg);
		}
	}

	class LoaderEnter {
		static void Main(string[] args) {

			Console.WriteLine("== start");
			(new Loader()).loadLib();
			Console.WriteLine("== end");

		}
	}
}
