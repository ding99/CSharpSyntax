﻿using System;

namespace Dictionary {
	class Entrance {

		public static void Main() {
			Console.WriteLine("== Start Examining Dictionary");
			ExamineKey key = new ExamineKey();
			key.Start();

			IntKey ikey = new IntKey();
			ikey.Start();

			ExamingDictionary td = new ExamingDictionary();
			td.Start();

			DRussian dr = new DRussian();
			dr.accMulti();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
