using System;
using System.IO;
using System.Reflection;

namespace MergeSrc2 {

	public class MergeScr02 {
		public MergeScr02() {
		}

		public void dsp02(string msg) {
			Console.WriteLine("--- src02 [" + msg + "]");
			Console.WriteLine("  work dir [" + Directory.GetCurrentDirectory() + "]");

			try {
				Assembly dll = Assembly.LoadFrom("MergeSrc1.dll");
				Type type = dll.GetType("MergeSrc1.MergeSrc01");
				object instance = Activator.CreateInstance(type);
				type.GetMethod("dsp01").Invoke(instance, new object[] { msg });
			}
			catch(Exception e) {
				Console.WriteLine("  error [" + e.Message + "]");
			}

			//(new MergeSrc1.MergeSrc01()).dsp01(msg);

			Console.WriteLine("--- src02 [" + msg + "]");
			Console.WriteLine("  work dir [" + Directory.GetCurrentDirectory() + "]");
		}
	}
}
