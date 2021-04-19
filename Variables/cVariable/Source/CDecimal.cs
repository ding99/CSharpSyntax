using System;
using System.Collections.Generic;
using System.Linq;

namespace CVariable {
	public class CDecimal {
		public CDecimal() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Start Examining Decimal");
		}

		public void MoneyDivision() {
			Action(20.1m, 4);
			Action(23.32m, 5);
		}

		private void Action(Decimal mount, int divisor) {
			List<decimal> list = new List<decimal>();

			if (divisor > 0)
				for (int i = 0; i < divisor; i++)
					list.Add(Math.Round(mount / divisor, 2));
			else list.Add(mount);

			Console.Write($"Original ({mount})");
			foreach (var a in list)
				Console.Write($" {a}");
			Console.WriteLine($" Sum ({list.Sum()})");
		}
	}
}
