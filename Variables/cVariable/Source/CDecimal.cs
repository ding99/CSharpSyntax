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
			Action(13.33m, 153);
			Action(10m, 33);
		}

		private void Action(Decimal total, int divisor) {
			Console.WriteLine("-- Action 1");

			Console.Write($"Original ({total})");
			List<decimal> list = new List<decimal>();

			if (divisor > 0)
				while(divisor > 0) {
					decimal mount = Math.Round(total / divisor, 2);
					list.Add(mount);
					total -= mount;
					divisor--;
				}
			else list.Add(total);

			foreach (var a in list)
				Console.Write($" {a}");
			Console.WriteLine($" Sum ({list.Sum()})");
		}
	}
}
