using System;

namespace cArray
{

	public class CheckArray {
		public CheckArray() {
		}

		#region partial
		private void Dsp(byte[] b, string s) {
			Console.WriteLine(s + " : " + BitConverter.ToString(b).Replace("-", " "));
		}
		public void Partial() {
			Console.WriteLine(Environment.NewLine + "--- Partial");

			byte[] ori = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			this.Dsp(ori, "Original");

			Array.Resize<byte>(ref ori, 6);
			this.Dsp(ori, "Resized ");

			Array.Resize<byte>(ref ori, 8);
			this.Dsp(ori, "Resized2");

			Console.WriteLine();

			ori = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			this.Dsp(ori, "Original");

			int p = 1;
			byte key = 9;
			p = Array.BinarySearch<byte>(ori, key);
			Console.WriteLine("Search key(" + key + ") : [" + p + "]");

			byte[] dst = new byte[16];
			ori.CopyTo(dst, 2);
			this.Dsp(dst, "CopyTo  ");
		}
		#endregion

		public void DspString() {
			Console.WriteLine(Environment.NewLine + "--- toString");

			byte[] ori = new byte[] { 111, 112, 113, 114, 115, 116, 117, 118 };
			this.Dsp(ori, "Original    ");

			string dst1 = BitConverter.ToString(ori);
			Console.WriteLine("BitConverter: " + dst1);

			string dst2 = Convert.ToBase64String(ori);
			Console.WriteLine("ToBase64    : " +  dst2);
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

		public byte[] ReBin(byte[] src, byte[] key, byte[] rep) {
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

		public void ReplaceBin() {

			byte[] b = { 0, 1, 2, 3, 5, 4, 5, 6, 7, 8, 3, 5, 6, 3};
			this.Dsp(b, "source");
			byte[] c = this.ReBin(b, new byte[] { 5, 6 }, new byte[] { 13, 12 });
			this.Dsp(c, "first ");
			b = this.ReBin(c, new byte[] { 3, 5 }, new byte[] { 11, 11, 11 });
			this.Dsp(b, "second");
			c = this.ReBin(b, new byte[] { 2, 0xb }, new byte[] { 15, 15 });
			this.Dsp(c, "third ");
		}

	}
}
