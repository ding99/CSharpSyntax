using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CStrings {

	public class TestChar {
		private void oneChar(char a){
			int v = (int)a;
			Console.WriteLine("-- [" + a + "] value {" + v.ToString("x2") + "}");
		}
		public void chars() {
			Console.WriteLine("Char Test");
			this.oneChar('a');
			this.oneChar('3');
			this.oneChar(' ');
			this.oneChar('\'');
			this.oneChar('?');
		}

		#region scc
		#region define
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
		// degree sign is 00B0, not 00BA
		private char[] spcs = new char[] {
			'\u00ae','\u00b0','\u00bd','\u00bf','\u2122','\u00a2','\u00a3','\u266a',
			'\u00e0',' ','\u00e8','\u00e2','\u00ea','\u00ee','\u00f4','\u00fb'
		};
		#region ext
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
		#endregion

		#region extended char
		private bool isex(char[] b, string m) {
			for(int i = 0; i < b.Length; i++)
				if(b[i].ToString() == m)
					return true;
			return false;
		}
		private void clsExtend(string s) {

			bool ded = false;
			string ns = String.Empty;
			List<int> left = new List<int>();

			for(int i = 0; i < s.Length; i++)
				if(ded || i + 1 == s.Length || (!this.isex(this.ext1, s.Substring(i + 1, 1)) &&
					!this.isex(this.ext2, s.Substring(i + 1, 1)))) {
					left.Add(i);
					ded = false;
				}
				else
					ded = true;

			foreach(int i in left)
				ns += s.Substring(i, 1);
			Console.WriteLine("[" + s + "] -> [" + ns + "]");
		}
		public void clses(){
			this.clsExtend("CAFEÉÉÉ DE LAS NIÑAS[OÔxUÜxOÒ]");
			this.clsExtend("aUÜaAÀaAÂaCÇaEÈaEÊaEËaIÎaIÏaOÔaUÙaUÛ");
			this.clsExtend("bAÃbIÌbOÒbOÕbAÄbAÅbÑbiïb");
			this.clsExtend("áéíóúñàèâêîôû");
			this.clsExtend("uüeëiïuùiìoöòoõöaåxxçxx");
		}
		#endregion

		#region special char
		public class SSeg{
			public int start;
			public int size;

			public SSeg(){
				this.start = 0;
				this.size = 0;
			}
		}

		private void spcone(string s){
			List<SSeg> ss = new List<SSeg>();
			string pre = String.Empty, crt = String.Empty;
			int stt = 0;

			for(int i = 0; i < s.Length; i++)
				if(this.isex(this.spcs, crt = s.Substring(i, 1)) && crt != " "){
					if(String.IsNullOrWhiteSpace(pre)) {
						stt = i;
						pre = crt;
					}
					else if(pre != crt) {
						if(stt + 1 < i)
							ss.Add(new SSeg { start = stt, size = i - stt });
						stt = i;
						pre = crt;
					}
				}
				else {
					if(!String.IsNullOrWhiteSpace(pre) && stt + 1 < i)
						ss.Add(new SSeg{ start = stt, size = i - stt});
					pre = String.Empty;
				}

			if(!String.IsNullOrWhiteSpace(pre) && stt + 1 < s.Length)
				ss.Add(new SSeg { start = stt, size = s.Length - stt });

			Console.Write("[" + s.Length + "]");
			foreach(SSeg g in ss)
				Console.Write(" " + g.start + "-" + g.size);
			Console.WriteLine();

		}
		public void spcc() {
			this.spcone("♪♪♪ Tom And Jerry Kids ♪♪♪♪");
			this.spcone("♪♪ Tom And Jerry Kids ®®®♪");
			this.spcone("½½½½½♪ Tom And Jerry Kids ♪");
			this.spcone("♪ Tom And _♪♪♪♪♪♪♪♪♪ _♪♪♪♪♪♪½½½♪♪♪♪♪♪♪♪");
		}

		private void quaver(int n, string s) {
			CommonLogs.CommonLog re = new CommonLogs.CommonLog(@"D:\workFolder\Test\quaver.log", "quaver");

			re.log("== " + n + " [" + s + "]" + Regex.IsMatch(s, "\u266a") + " / " +
			(!String.IsNullOrWhiteSpace(s) && Regex.IsMatch(s, "[^'\u266a']")));
			//re.log("     [" + s + "]" + Regex.IsMatch(s, "[\u266a, \u1d160]"));
			
		}
		public void quavers() {
			string s = "aaaaa";
			this.quaver(1, s);
			s += '\u266a';
			this.quaver(2, s + "bbbbb");
			s = String.Empty;
			this.quaver(3, s);
			this.quaver(5, " "+ '\t');
			s += '\u266a';
			this.quaver(6, s);
			this.quaver(7, s + "ccccc");

		}
		#endregion
		#endregion
	}

}