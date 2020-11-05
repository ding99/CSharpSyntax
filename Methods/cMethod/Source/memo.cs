using System;

namespace CMethod {
	public class CMemo {
		public CMemo() {
		}

		private byte[][] getMemos() {
			int m = 0, n = 3;
			byte[][] mss = new byte[n][];

			for(int i = 0; i < n; i++) {
				m = 6 + i * 3;
				mss[i] = new byte[m];
				for(int j = 0; j < m; j++)
					mss[i][j] = (byte)(i * 20 + j);
			}

			return mss;
		}

		public void checkmemos() {
			byte[][] a = this.getMemos();

			Console.WriteLine("=== line " + a.Length + " ===");
			foreach(byte[] b in a) {
				foreach(byte c in b)
					Console.Write(c.ToString("D2") + " ");
				Console.WriteLine();
			}
		}

	}
}