using System;
using System.Collections.Generic;

namespace cArray {

	public class GArray {
		public GArray() {
		}

		#region partial
		private void dsp(byte[] b, string s) {
			Console.WriteLine(s + " : " + BitConverter.ToString(b).Replace("-", " "));
		}
		public bool Partial() {
			Console.WriteLine(Environment.NewLine + "--- Partial");

			byte[] ori = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			this.dsp(ori, "Original");

			Array.Resize<byte>(ref ori, 6);
			this.dsp(ori, "Resized ");

			Array.Resize<byte>(ref ori, 8);
			this.dsp(ori, "Resized2");

			Console.WriteLine();

			ori = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			this.dsp(ori, "Original");

			int p = 1;
			byte key = 9;
			p = Array.BinarySearch<byte>(ori, key);
			Console.WriteLine("Search key(" + key + ") : [" + p + "]");

			byte[] dst = new byte[16];
			ori.CopyTo(dst, 2);
			this.dsp(dst, "CopyTo  ");

			return true;
		}
		#endregion

		public bool toString() {
			Console.WriteLine(Environment.NewLine + "--- toString");

			byte[] ori = new byte[] { 111, 112, 113, 114, 115, 116, 117, 118 };
			this.dsp(ori, "Original    ");

			string dst1 = BitConverter.ToString(ori);
			Console.WriteLine("BitConverter: " + dst1);

			string dst2 = Convert.ToBase64String(ori);
			Console.WriteLine("ToBase64    : " +  dst2);

			return true;
		}

		public int FindBin(byte[] src, byte[] key) {
			int idx = -1, mth = 0;

			for(int i = 0; i < src.Length; i++) {
				if(src[i] == key[mth]) {
					if(mth + 1 == key.Length) {
						idx = i - mth;
						break;
					}
					mth++;
				}
				else
					mth = 0;
			}

			return idx;
		}

		public byte[] reBin(byte[] src, byte[] key, byte[] rep) {
			byte[] dst = src;
			int idx = -1;

			while(true) {
				if((idx = this.FindBin(src, key)) < 0) break;

				dst = new byte[src.Length + rep.Length - key.Length];
				System.Buffer.BlockCopy(src, 0, dst, 0, idx);
				System.Buffer.BlockCopy(rep, 0, dst, idx, rep.Length);
				System.Buffer.BlockCopy(
					src, idx + key.Length,
					dst, idx + rep.Length,
					src.Length - (idx + key.Length));

				src = dst;
			}

			return dst;
		}

		public bool replaceBin() {

			byte[] b = { 0, 1, 2, 3, 5, 4, 5, 6, 7, 8, 3, 5, 6, 3};
			this.dsp(b, "source");
			byte[] c = this.reBin(b, new byte[] { 5, 6 }, new byte[] { 13, 12 });
			this.dsp(c, "first ");
			b = this.reBin(c, new byte[] { 3, 5 }, new byte[] { 11, 11, 11 });
			this.dsp(b, "second");
			c = this.reBin(b, new byte[] { 2, 0xb }, new byte[] { 15, 15 });
			this.dsp(c, "third ");

			return true;
		}

	}

	class Entrance {
		static void Main(string[] args) {

			Console.WriteLine("== start");

			GArray ga = new GArray();
			bool ret = true;

			//ret = ga.Partial();
			//ret = ga.toString();
			ret = ga.replaceBin();

			Console.WriteLine(Environment.NewLine + "== end");
		}
	}
}
