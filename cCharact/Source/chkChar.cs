using System;
using System.IO;

namespace cCharact {

	public class charct {

		public charct() {
		}

		#region data
		private char[] stds = new char[] {
			' ','!','"','#','$','%','&','\'','(',')','\u00e1','+',',','-','.','/',
			'0','1','2','3','4','5','6','7','8','9',':',';','<','=','>','?',
			'@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O',
			'P','Q','R','S','T','U','V','W','X','Y','Z','[','\u00e9',']','\u00ed','\u00f3',
			'\u00fa','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o',
			'p','q','r','s','t','u','v','w','x','y','z','\u00e7','\u00f7','\u00d1','\u00f1','\u2588'
		};

		// offset 0x1130 with odd parity (91b0)
		// 91b0 - transparent space (special ??? )
		private char[] spcs = new char[] {
			'\u00ae','\u00ba','\u00bd','\u00bf','\u2122','\u00a2','\u00a3','\u266a',
			'\u00e0',' ','\u00e8','\u00e2','\u00ea','\u00ee','\u00f4','\u00fb'
		};

		// offset 1220 with odd parity (9220)
		// how to display \u120 ???
		private char[] ext1 = new char[]{
			'\u00c1','\u00c9','\u00d3','\u00da','\u00dc','\u00fc','\u2018','\u00a1',
			'\u002a','\u2019','\u2014','\u00a9','\u2120','\u00b7','\u201c','\u201d',
			'\u00c0','\u00c2','\u00c7','\u00c8','\u00ca','\u00cb','\u00eb','\u00ce',
			'\u00cf','\u00ef','\u00d4','\u00d9','\u00f9','\u00db','\u00ab','\u00bb'
		};

		// offset 1320 with odd parity (9220)
		// u2503 -> u2016, u2502, u2503, or another ???
		private char[] ext2 = new char[]{
			'\u00c3','\u00e3','\u00cd','\u00cc','\u00ec','\u00d2','\u00f2','\u00d5',
			'\u00f5','{','}','\\','^','_','|','~',
			'\u00c4','\u00e4','\u00d6','\u00f6','\u00df','\u00a5','\u00a4','\u2502',
			'\u00c5','\u00e5','\u00d8','\u00f8','\u250c','\u2510','\u2514','\u2518'
		};
		#endregion

		public void dsp() {
			int i = 0;

			using(StreamWriter sw = new StreamWriter(@"c:\test\testscc\chrs.txt", false, System.Text.Encoding.Unicode)) {

				sw.WriteLine("-- Standard Characters");
				for(i = 0; i < stds.Length; i++) {
					sw.Write(stds[i] + " ");
					if((i % 16) == 15)
						sw.WriteLine();
				}
				sw.WriteLine();

				sw.WriteLine("-- Special Characters");
				for(i = 0; i < spcs.Length; i++) {
					sw.Write(spcs[i] + " ");
					if((i % 16) == 15)
						sw.WriteLine();
				}
				sw.WriteLine();

				sw.WriteLine("-- Extended Characters");
				for(i = 0; i < ext1.Length; i++) {
					sw.Write(ext1[i] + " ");
					if((i % 16) == 15)
						sw.WriteLine();
				}
				if((i % 16) != 0) sw.WriteLine();
				for(i = 0; i < ext2.Length; i++) {
					sw.Write(ext2[i] + " ");
					if((i % 16) == 15)
						sw.WriteLine();
				}
				sw.WriteLine();
			}
		}

		private int parity(int d) {
			int pr = 128, m = 1;
			for(int i = 0; i < 7; i++) if((d & (m << i)) != 0)
					pr ^= 128;
			return d | pr;
		}

		private void onep(int d){
			Console.WriteLine("{0:x2} {1:x2}", d, this.parity(d));
		}

		public void oddParity() {
			this.onep(0x11);
			this.onep(0x76);

			for(int i = 3; i < 8; i++) {
				this.onep(i);
				this.onep(i + 0x61);
			}
		}

		public void getUnic() {
			string src = "We 123";
			src += '\u00ae';
			src += '\u2510';
			Console.WriteLine(src);

			char[] b = new char[src.Length];
			using(StringReader sr = new StringReader(src)) {
				sr.Read(b, 0, src.Length);
				Console.WriteLine(b);
				for(int i = 0; i < b.Length; i++)
					Console.Write("[" + b[i] + "-" + ((int)b[i]).ToString("x") + "] ");
				Console.WriteLine();
			}
		}

		public void charUni(char[] b, string m) {
			Console.WriteLine("-- " + m);
			for(int i = 0; i < b.Length; i++){
				Console.Write(i.ToString("x2") + "-" + ((int)b[i]).ToString("x") + " ");
				if((i % 8) == 7) Console.WriteLine();
			}			
		}

		public void charUnic(){
			this.charUni(this.stds, "standard");
			this.charUni(this.spcs, "special");
			this.charUni(this.ext1, "extend1");
			this.charUni(this.ext2, "extend2");
		}

		public void char2byte() {
			byte[] buf = new byte[60];
			string s = "1233a1";
			for(int i = 0; i < s.Length; i += 2)
				Console.Write(" " + int.Parse(s.Substring(i, 2), System.Globalization.NumberStyles.HexNumber));
			Console.WriteLine();
		}
		
		public void value() {
			int key = (int)'f';
			Console.WriteLine("<f> value is " + key + "(" + key.ToString("x") + "h).");
		}
	}

}
