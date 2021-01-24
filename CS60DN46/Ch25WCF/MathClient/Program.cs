using MathClient.ServiceReference2;
using System;

namespace MathClient {
	class Program {
		static void Main() {
			Console.WriteLine("***** The Async Math Client *****");

			using(BasicMathClient proxy = new BasicMathClient()) {
				proxy.Open();

				IAsyncResult result = proxy.BeginAdd(2, 3,
					ar => {
						Console.WriteLine("2 + 3 = {0}", proxy.EndAdd(ar));
					},
					null);

				while (!result.IsCompleted) {
					System.Threading.Thread.Sleep(200);
					Console.WriteLine("Client working...");
				}
			}
		}
	}
}
