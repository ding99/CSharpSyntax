using System;

namespace CVariable {
	public class Variables {

		public Variables() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Variables Basis");
			SizeOfs();
		}

		private void SizeOfs() {
			Console.WriteLine("-- size of variable");
			Console.WriteLine($"bool {sizeof(bool)}");
			Console.WriteLine($"byte {sizeof(byte)}, sbyte {sizeof(sbyte)}, char {sizeof(char)}, short {sizeof(short)}, ushort {sizeof(ushort)}, int {sizeof(int)}, uint {sizeof(uint)}, long {sizeof(ulong)}, ulong {sizeof(long)}");
			Console.WriteLine($"float {sizeof(float)}, double {sizeof(double)}, decimal {sizeof(decimal)}");

			double f1 = 12345E2f, f2 = 12345E-2f;
			Console.WriteLine($"The value of '12345E2f' is {f1}, '12345E-2f' is {f2}");
		}

		public void ByteDef() {
			Console.WriteLine("-- byte type");

			byte[] vr = null;
			Console.WriteLine("Declare a byte[] which was assigned as null is null : " + (vr == null));

			vr = new byte[10];
			Console.WriteLine("Declare a byte[] with length 10 is null : " + (vr == null));

			try {
				Console.WriteLine("Declare a byte[] with length 10000000000 :");
				vr = new byte[10000000000];
				Console.WriteLine("   null " + (vr == null));
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}
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
		public void Rows() {
			Console.WriteLine("-- Test float for Teletext");
			this.toTele(83);
			this.toTele(92);
			this.toInvi(20);
			this.toInvi(22);
		}

		public static void ToDouble() {
			Console.WriteLine("-- int to double");
			int int1 = 25000, int2 = 29970, int3 = 23976;
			Console.WriteLine(int1.ToString() + " -> " + ((double)int1 / 1000).ToString());
			Console.WriteLine(int2.ToString() + " -> " + ((double)int2 / 1000).ToString());
			Console.WriteLine(int3.ToString() + " -> " + ((double)int3 / 1000).ToString());
		}

		public void Select() {
			Console.WriteLine("-- Select (need parentheses in ?: statement)");
			int a = 5, b = 6;
			int c = a + b > 7 ? 7 : 0;
			int d = (a + b) > 7 ? 7 : 0;
			Console.WriteLine($"a {a}, b {b}, [a+b:] woParenthesese {c}, wParenthesese {d}");
		}

		public void Valuable() {
			Console.WriteLine("-- HasValue of a nullable bool variable a");

			bool? a = null; Console.WriteLine("a(null)  : " + a.HasValue);
			a = true; Console.WriteLine("a(true)  : " + a.HasValue);
			a = false; Console.WriteLine("a(false) : " + a.HasValue);
			a = null; Console.WriteLine("a(null)  : " + a.HasValue);
		}
	}
}
