﻿using System;

namespace SortedSet {
	class Program {
		static void Main() {
			Console.WriteLine("== Start");
			Examining exam = new Examining();
			exam.Start();
			exam.unionwith();
			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
