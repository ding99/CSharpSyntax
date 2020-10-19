using System;

namespace RoundTrip {
	class HelloProgram {
		static void Main() {
			Console.WriteLine("Hello CIL code!");
			Console.ReadLine();
		}
	}
}

/*
 * ilasm /exe HelloProgramm.il /output=HelloProgramm.exe
 * peverify HelloProgramm.exe
 */