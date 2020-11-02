using System;

namespace CDllLoad {
	public class Loader {
		public void loadLib() {
			string msg = "Top_Message";
			CDllLibm.LibTransfer lt = new CDllLibm.LibTransfer();
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
