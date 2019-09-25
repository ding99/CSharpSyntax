using System;

namespace cDllLibm {
	public class LibTransfer {
		public LibTransfer() {
		}

		public void dspmid(string msg) {
			Console.WriteLine("  mid 1. start loading");

			try {
				System.Reflection.Assembly dll = System.Reflection.Assembly.LoadFrom("cDllLib.dll");
				Console.WriteLine("  mid 2. dll[" + dll.FullName + "]");

				Type type = dll.GetType("cDllLib.LibDsp", true);
				Console.WriteLine("  mid 3. type[" + type + "]");

				object instance = Activator.CreateInstance(type);
				Console.WriteLine("  mid 4. instance[" + instance + "] message[" + msg + "]");

				type.GetMethod("dspline").Invoke(instance, new object[] { msg });
				Console.WriteLine("  mid 5. getmethod");
			}
			catch(Exception e) {
				Console.WriteLine("  mid 0. error[" + e.Message + "]");
			}

			Console.WriteLine("  mid 6. end loading");
		}
	}
}
