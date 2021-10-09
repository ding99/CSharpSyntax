using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CStrings {
	class CIndex {
		public CIndex() {
			Console.ForegroundColor = ConsoleColor.Green;
		}

		public void ExamineIndex() {
			string source = "abcdefg", key = "ef";
			int offset1 = 2, offset2 = 3;
			Console.WriteLine($"source [{source}]; key [{key}], offset1 [{offset1}], offset2 [{offset2}]");
			
			Console.WriteLine($"IndexOf(source)          : {source.IndexOf(key)}");
			Console.WriteLine($"IndexOf(source, offset1) : {source.IndexOf(key, offset1)}");
			Console.WriteLine($"IndexOf(source, offset2) : {source.IndexOf(key, offset2)}");
		}
	}
}
