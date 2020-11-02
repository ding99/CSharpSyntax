using System;

namespace CVariable {
	public class Vari {
		public bool bytedef() {

			byte[] vr = null;
			Console.WriteLine("-- null " + (vr == null));

			vr = new byte[10];
			Console.WriteLine("-- null " + (vr == null));

			try {
				vr = new byte[10000000000];
				Console.WriteLine("   null " + (vr == null));
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
				return false;
			}

			return true;
		}

		private void toTele(int value) {
			double stp = 100.0 / 23, stm = 4.3478;
			Console.WriteLine(value + " to map teletext  : " + (Math.Floor(value / stp) + 1) +
				" / " + (Math.Floor(value / stm) + 1));
		}
		private void toInvi(int value) {
			double stp = 100.0 / 23, stm = 4.3478;
			Console.WriteLine(value + " to map in-vision : " + Math.Ceiling((value - 1) * stp) +
				" / " + Math.Ceiling((value - 1) * stm));
		}
		public bool rows() {

			this.toTele(83);
			this.toTele(92);
			Console.WriteLine();
			this.toInvi(20);
			this.toInvi(22);

			return true;
		}

		public bool toFloat() {
			int int1 = 25000, int2 = 29970, int3 = 23976;
			Console.WriteLine(int1.ToString() + " -> " + ((double)int1 / 1000).ToString());
			Console.WriteLine(int2.ToString() + " -> " + ((double)int2 / 1000).ToString());
			Console.WriteLine(int3.ToString() + " -> " + ((double)int3 / 1000).ToString());
			return true;
		}

		public void sel() {
			int a = 5, b = 6;
			int c = a + b > 7 ? 7 : 0;
			int d = (a + b) > 7 ? 7 : 0;
			Console.WriteLine("a " + a + " b " + b + " c " + c + " d " + d);
		}

		public void valuable() {
			bool? a = null;
			Console.WriteLine("0 a " + a.HasValue + (a.HasValue ? " " + a : ""));

			a = true;
			Console.WriteLine("1 a " + a.HasValue + (a.HasValue ? " " + a : ""));

			a = false;
			Console.WriteLine("2 a " + a.HasValue + (a.HasValue ? " " + a : ""));

			a = null;
			Console.WriteLine("3 a " + a.HasValue + (a.HasValue ? " " + a : ""));
		}
	}
}
