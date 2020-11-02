using System;

namespace CDateTime {

	public class CTime {
		private void dsp(DateTime dt, string m) {
			//Console.WriteLine(dt.ToString(@"yyyy-MM-dd  HH:mm:ss  hh:mm:ss tt") + "  " + m);
			Console.WriteLine(dt.ToString(@"yyyy_MM_dd_HH_mm_ss_ffff") + "  " + m);
		}
		public void Uni() {
			DateTime crt = DateTime.Now;
			DateTime utc = DateTime.UtcNow;

			this.dsp(crt, "now 1");
			this.dsp(crt.ToUniversalTime(), "now_utc");

			this.dsp(utc, "utc");
			this.dsp(utc.ToLocalTime(), "utc_local");

			crt = DateTime.Now;
			this.dsp(crt, "now 2");
			this.dsp(crt.ToUniversalTime(), "now_utc");
		}

		public void sub() {
			DateTime t1 = DateTime.Now;
			Console.WriteLine("t1 : " + t1);

			System.Threading.Thread.Sleep(2000);

			double min = DateTime.Now.Subtract(t1).TotalMinutes;
			Console.WriteLine(min);

		}
	}

	class Program {
		static void Main(string[] args) {
			Console.WriteLine("=== Start");
			CTime ct = new CTime();

			ct.Uni();
			//ct.sub();
			Console.WriteLine("=== End");
		}
	}
}
