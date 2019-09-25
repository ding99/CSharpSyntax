using System;
using System.Diagnostics;

namespace cStopWatch {

	public class Watch {
		public Watch() { }

		public void testWatch() {
			Console.WriteLine("== Start");

			//Start
			DateTime start0 = DateTime.Now;
			var sw1 = Stopwatch.StartNew();
			var sw2 = Stopwatch.StartNew();

			//Timing 1
			System.Threading.Thread.Sleep(1000);
			sw1.Stop();
			string mid0 = string.Format("{0:0.0000}", DateTime.Now.Subtract(start0).TotalMilliseconds);
			string mid1 = string.Format("{0:0.0000}", sw1.Elapsed.TotalMilliseconds);
			string mid2 = string.Format("{0:0.0000}", sw2.Elapsed.TotalMilliseconds);

			//Timing 2
			System.Threading.Thread.Sleep(1000);
			string end0 = string.Format("{0:0.0000}", DateTime.Now.Subtract(start0).TotalMilliseconds);
			string end1 = string.Format("{0:0.0000}", sw1.Elapsed.TotalMilliseconds);
			string end2 = string.Format("{0:0.0000}", sw2.Elapsed.TotalMilliseconds);

			Console.WriteLine($"[Unit: ms]      Reference      W1(STOP 1s)    W2(NON-STOP)");
			Console.WriteLine($"Timing 1s:      {mid0}      {mid1}      {mid2}");
			Console.WriteLine($"Timing 2s:      {end0}      {end1}      {end2}");

			Console.WriteLine("== End");
		}
	}

	class Program {
		static void Main(string[] args) {
			new Watch().testWatch();
		}
	}
}
