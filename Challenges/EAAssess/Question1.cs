using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Threading;

namespace EAAssess {

	/*
	 * Number of Lucky numbers between L and H.
	 * */

	class Question1 {
		public void Start() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Print the number of the lucky numbers between L and H");

			long L = 58, H = 72;
			Console.WriteLine($"L {L} - H {H}: result {GetNumber(L, H)}");
		}

		public int GetNumber(long L, long H) {
			int count = 0;

			string a;
			for (long i = L; i <= H; i++) {
				if ((a = i.ToString()).Contains('8')) {
					if (!a.Contains('6')) count++;
				} else if (a.Contains('6')) count++;
			}


			return count;
		}
	}
}
