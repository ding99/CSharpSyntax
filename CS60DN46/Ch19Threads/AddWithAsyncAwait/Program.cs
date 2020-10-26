using System;
using System.Threading;
using System.Threading.Tasks;

namespace AddWithAsyncAwait {
	class Program {
		static void Main() {
			Console.WriteLine("***** Working with Async/Await *****");
			AddAsync();
			Console.ResetColor();
		}

		private static async Task AddAsync() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Adding with Async/Await");
			Console.WriteLine($"ID of thread in Primary: {Thread.CurrentThread.ManagedThreadId}");

			AddParams ap = new AddParams(10, 20); await Sum(ap);

			await Sum(new AddParams(300, 500));

			Console.WriteLine("Other thread is done!"); ;
		}

		static async Task Sum(object data) {
			await Task.Run(() => {
				if (data is AddParams) {
					Console.WriteLine($"ID of thread in Add(): {Thread.CurrentThread.ManagedThreadId}");

					AddParams ap = (AddParams)data;
					Console.WriteLine($"{ap.a} + {ap.b} is {ap.a + ap.b}");
				}
			});
		}
	}
}
