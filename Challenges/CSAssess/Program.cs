using System;

namespace CSAssess {
	class Program {
		public static void Main() {
			try {
				try {
					int x = 0;
					int y = 5 / x;
				}
				catch (DivideByZeroException e) {
					Console.WriteLine("Caught inner Divide by Zero Exception!");
					throw;
				}
				catch (Exception e) {
					Console.WriteLine("Caught inner General Exception!");
					throw;
				}
			}
			catch (DivideByZeroException e) {
				Console.WriteLine("Caught outer Divide by Zero Exception!");
			}
			catch(Exception e) {
				Console.WriteLine("Caught outer General Exception!");
			}

			Console.ReadLine();
		}
	}
}
