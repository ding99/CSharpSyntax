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
		}

		public void ExistOne<T>(IList<T> one) {
			Console.Write($"IsNull [{one == null}]");
			if(one != null) {
				Console.Write($", Any() [{one.Any()}]");
				Console.Write($", Count [{one.Count}]");
				Console.Write($", Count() [{one.Count()}]");
			}
			Console.WriteLine();
		}
	}
}
