using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumarable {
	public class Existence {
		public Existence() {
			Console.ForegroundColor = ConsoleColor.Yellow;
		}

		public void ExistAny() {
			ExistOne(new List<string>());
			ExistOne(new List<double>());
			ExistOne(new List<string>{"A1", "B2", "C3"});
			ExistOne(new List<object> { 1, 2.1, true, "ABC"});
		}

		public void ExistOne<T>(IEnumerable<T> one) {

			StringBuilder b = new StringBuilder("[");

			var list = one.ToList();
			for (int i = 0; i < list.Count(); i++)
				b.Append(i == 0 ? "" : " ").Append("(").Append(list[i]).Append(")");
			b.Append("]");

			b.Append($", Any() <{one.Any()}>");
			b.Append($", Count() <{one.Count()}>");

			Console.WriteLine(b.ToString());
			}
		}
}
