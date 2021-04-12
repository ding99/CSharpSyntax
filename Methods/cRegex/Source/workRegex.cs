using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CRegex {

	struct StyleKey {
		public static string italicOn = "<i>";
		public static string italicOff = "</i>";
	}

	public class TReg {
		private MatchCollection m;

		public TReg() {
			Console.ForegroundColor = ConsoleColor.Yellow;
		}

		#region past
		private void DisplayMatches(string s) {
			Console.WriteLine("(" + s + ")");
			Console.Write(this.m.Count + " : ");
			for (int i = 0; i < this.m.Count; i++)
				Console.Write("[" + this.m[i].Value + "]");
			Console.WriteLine();
		}
		private void OneSpaceCheck(string s) {
			this.m = (new Regex(@"( *)(\w+)")).Matches(s);
			DisplayMatches(s);
		}
		public void rSpace() {
			Console.WriteLine("-- Examine Space");
			OneSpaceCheck("Lt Rt");
			OneSpaceCheck("Lt  Rt");
		}

		public void rComma() {
			Console.WriteLine("-- Examine Comma");
			string sl1 = @" pro, y4#@;%&.2*2-_{p10}~+le, 72x?4'8'0p,  51 !k""b""/s, PAR 8:9 [DAR 4:3], 3.9 fps";
			this.m = (new Regex(@"(,)?( )[\w /:;|.!()'#$%&{}~@\?\+\-\*\[\]""]+")).Matches(sl1);
			DisplayMatches(sl1);
		}

		public void rFind1() {
			Console.WriteLine("-- rFind1");
			string s1 = "720x580p", s2 = "720_480p", key = @"([0-9]+)x([0-9]+)";
			Console.WriteLine($"Pattern: [{key}]");
			Match mc1 = Regex.Match(s1, key);
			Console.WriteLine("[" + s1 + "] " + (mc1.Success ? mc1.ToString() : "NO"));
			Match mc2 = Regex.Match(s2, key);
			Console.WriteLine("[" + s2 + "] " + (mc2.Success ? mc2.ToString() : "NO"));
		}

		public void rFind2() {
			Console.WriteLine("-- rFind2");
			string s1 = "11:22:33.89", key = @"(:)?[\w.]+";
			Console.WriteLine($"String [{s1}], Pattern [{key}]");
			int manu = (11 * 60 + 22) * 60 + 33;

			m = (new Regex(key)).Matches(s1);
			DisplayMatches(s1);

			double d1 = (Convert.ToInt32(m[0].Value) * 60 + Convert.ToInt32(m[1].Value.Substring(1))) * 60;
			d1 += Convert.ToDouble(m[2].Value.Substring(1));
			Console.WriteLine("Ref " + manu + " Cal " + d1);
		}

		private void quote(string s) {
			string[] ss = s.Split('\"');
			Console.Write("[" + s + "] " + ss.Length);
			for(int i = 0; i < ss.Length; i++)
				Console.Write(" {" + ss[i] + "}");
			Console.WriteLine();
		}

		public void quotes() {
			this.quote("شريك مؤسس لموقع الترفيه‎><‏‎،\"Reddit\" ،‎والأخبار الاجتماعية");
			this.quote("‏‏‏ثمة إحساس عميق بالخسارة‎><‏‎،\"Highland Park\" ‏هذه الليلة في");
			this.quote("،\"‎الزهرة‎\" ‏رمز‎ ،\"‎عطارد‎\" ‏رمز");
			this.quote(".\"Aaron\" ‏المضيف‎ .\"Aaron\" ‏أنا مضيفكم");
			this.quote("اليافع الطائرة إلى‎ \"Aaron Swartz\" ‏ركب‎><‏‎.‎لحضور جلسات المحكمة العليا‎ \"‎واشنطن‎\"");
		}


		private void endone(string s) {
			Console.WriteLine("------ " + s.StartsWith(".") + " / " + s.EndsWith("."));
		}
		public void ends() {
			this.endone("شريك مؤسس لموقع الترفيه‎><‏‎‎والأخبار الاجتماعية");
			this.endone("‏‏‏ثمة إحساس عميق بالخسارة‎><‏‎‏هذه الليلة في.");
			this.endone("،‎الزهرة‎‏رمز‎‎عطارد‎‏رمز");
			this.endone(".‏المضيف‎Aaron‏أنا مضيفكم");
			this.endone("اليافع الطائرة إلى‎‏ركب‎><‏‎.‎لحضور جلسات المحكمة العليا‎‎واشنطن‎");
		}

		public void rMatch() {
			Console.WriteLine("-- rMatch");
			string[] ls = new string[] { " ENG 5.1 L ", " PTB 5.1 R", " ENG 7.1 L", " ENG 7.1 R",
				" ENG 7.1 C", " ENG 7.1 LFE", " ENG 7.1 Ls", " ENG 7.1 Rs", " ENG 7.1 Lr", " ENG 7.1 Rr" };
			string key = @" (\w)+", mid = String.Empty;
			Match mc;
			foreach(string s in ls) {
				Console.Write("[" + s + "]");
				mc = Regex.Match(s, key, RegexOptions.RightToLeft);
				if(mc.Success && mc.Groups.Count > 0) {
					Console.Write(" - [" + mc.Groups[0].Value + "]");
				}
				Console.WriteLine();
			}
		}

		public void rMatchi() {
			Console.WriteLine("-- rMatchi");
			string[] ls = new string[] { "<i>aaaaa</i>", "aaa<i>bbb</i>ccc<i>dd23 d</i>eee", "<i>bbbb</i>cccc<i>dddd</i>" };
			string key = @"<i>(\w+)", mid = String.Empty;

			foreach(string s in ls) {
				this.m = (new Regex(key)).Matches(s);
				Console.Write($"[{s}]: Count({m.Count})");
				foreach (var a in this.m)
					Console.Write(" - [" + a + "]");
				Console.WriteLine();
			}
		}
		public void colorCode() {
			string s1 = "[2]aa,abb[3]b4ccc, [7]nnn ddd[3]  abcdefg";
			string s2 = " [2]aa,abb[3]b4ccc, [7]nnn ddd[3]  abcdefg";
			string s3 = "aa,abb[3]b4ccc, [7]nnn ddd[3]  abcdefg";
			Regex r = new Regex(@"\s*\[\d\]\s*"), begin = new Regex(@"^\[\d\]");

			Console.WriteLine("source:  {" + s1 + "} size(" + s1.Length + ")");
			Console.WriteLine("source:  {" + s2 + "} size(" + s2.Length + ")");
			Console.WriteLine("source:  {" + s3 + "} size(" + s3.Length + ")");

			Console.WriteLine(Environment.NewLine + "-- Match beginning");
			Console.WriteLine("s1: " + (begin.Match(s1).Success ? "matched" : "not match"));
			Console.WriteLine("s2: " + (begin.Match(s2).Success ? "matched" : "not match"));
			Console.WriteLine("s3: " + (begin.Match(s3).Success ? "matched" : "not match"));

			this.m = r.Matches(s1);
			int n = this.m.Count;
			Console.WriteLine(Environment.NewLine + "-- Matches count(" + n + ") for s1");
			for(int i = 0; i < n; i++)
				Console.WriteLine("- {" + m[i].Value + "}  Length " + m[i].Length + " Index " + m[i].Index + " Next " + m[i].NextMatch().Index);

			Console.WriteLine(Environment.NewLine + "-- Match for s1");
			Match mt;
			int stt = 0;
			while((mt = r.Match(s1, stt)).Success) {
				Console.WriteLine("  {" + mt.Value + "}  Length " + mt.Length + " Index " + mt.Index);
				stt = mt.Index + mt.Length;
			}

			Console.WriteLine(Environment.NewLine + "-- Delete spaces for s1");
			Console.WriteLine("Delete all spaces       {" + Regex.Replace(s1, "\\s", "") + "}");
			Console.WriteLine("Delete continous spaces {" + Regex.Replace(s1, "\\s{2,}", "") + "}");
			Console.WriteLine("Delete all spaces, [, ] {" + Regex.Replace(s1, @"\s|\[|\]", "") + "}");

			string t1 = Regex.Replace(s1, @"\[\d\]", "");
			string t2 = Regex.Replace(s2, @"\[\d\]", "");
			string t3 = Regex.Replace(s3, @"\[\d\]", "");

			Console.WriteLine(Environment.NewLine + "-- Delete color");
			Console.WriteLine("{" + s1 + "}\t\t{" + t1 + "}");
			Console.WriteLine("{" + s2 + "}\t\t{" + t2 + "}");
			Console.WriteLine("{" + s3 + "}\t\t{" + t3 + "}");
		}

		private void searchone(string s) {
			MatchCollection ms = (new Regex(@"\[\d\]")).Matches(s);
			int n = 0;

			Console.WriteLine("------");
			Console.WriteLine("{" + s + "} size(" + s.Length + ") matches(" + ms.Count + ")");
			foreach(Match m in ms) {
				Console.Write("  {" + m.Value + "} index(" + m.Index + ") size(" + m.Length + ") value(" + m.Value + ")");
				if(Int32.TryParse(Regex.Replace(m.Value, @"\[|\]", ""), out n))
					Console.Write(" -> " + n);
				Console.WriteLine();
			}

			if(ms.Count < 1)
				return;

			List<string> ls = new List<string>();
			for(int i = 0; i < ms.Count; i++) {
				if(i == 0 && ms[i].Index > 0)
					ls.Add(s.Substring(0, ms[i].Index));

				ls.Add(s.Substring(ms[i].Index + ms[i].Length,
					(i + 1 == ms.Count ? s.Length : ms[i + 1].Index) - ms[i].Index - ms[i].Length));
			}

			foreach(string l in ls)
				Console.WriteLine("- {" + l + "} size(" + l.Length + ")");

		}
		public void searchccode() {
			this.searchone("[2]aa,abb[3]b4ccc, [7]nnn ddd[3]  abcdefg");
			this.searchone(" [2]aa,abb[3]b4ccc, [7]nn-=##$%*n ddd[3]  abcdefg");
			this.searchone("aa,abb[3]b4ccc, [7]nnn ddd[3]  abcdefg");
			this.searchone("aa,abb3b4ccc, [7nnn ddd3]  abcdefg");
		}

		public void num() {
			string s = "<SYNC Start=18652 ID=Default><P Class=yueCC>你已進入邪惡巫師的洞穴</P></SYNC>";
			Match m = Regex.Match(s, "[0-9]+");
			Console.WriteLine("[" + (m.Success ? m.ToString() : "no") + "]  [" + m.Index + "] [" + m.Length + "]");
		}

		public void spaces() {
			string[] ss = new string[] {
				"     0   17.3838    +9.3643  103    -104     19.7751",
				"     1   20.4363   +15.5245  122    -102     18.3296",
				"     2   26.1676    -0.5322  122    -106     17.1305"
			};

			Regex r = new Regex(@"\s*[\d,.,-,+]+\s*");
			int n;

			foreach(string s in ss) {
				this.m = r.Matches(s);
				n = this.m.Count;
				Console.WriteLine("source:  {" + s + "} size(" + s.Length + ") n[" + n + "]");
				for(int i = 0; i < n; i++) {
					Console.WriteLine("- {" + m[i].Value + "}  Length " + m[i].Length + " Index " + m[i].Index + " Next " + m[i].NextMatch().Index);
				}
			}
		}

		public void mediatime() {
			string tc = "00:41:01.40";
			Console.WriteLine("source [" + tc + "]");

			MediaTime mt = new MediaTime(tc);
			Console.WriteLine("result [" + mt.hour + ":" + mt.minute + ":" + mt.second + "." + mt.millisecond + "]");
			double d1 = mt.ToSeconds();
			Console.WriteLine(d1);
		}
		#endregion

		#region content viewer
		private bool rowExch(ref string s) {
			#region second half English
			int n = s.Length, p = -1, nr = 0;
			string key = @"^[ a-zA-Z0-9_-]+$";

			for(int i = 0; i < n; i++)
				if(Regex.IsMatch(s.Substring(i), key)) {
					p = i;
					break;
				}

			if(p != -1) {
				for(nr = p; nr < n; nr++)
					if(s.Substring(nr, 1) != " ")
						break;
				s = s.Substring(nr) + s.Substring(p, nr - p) + s.Substring(0, p);
				return true;
			}
			#endregion

			#region first half English
			p = -1;
			for(int i = 0; i < n; i++)
				if(Regex.IsMatch(s.Substring(0, i + 1), key))
					p = i + 1;

			if(p == -1)
				return false;

			for(nr = p - 1; nr >= 0; nr--)
				if(s.Substring(nr, 1) != " ")
					break;
			s = s.Substring(p) + s.Substring(nr + 1, p - nr - 1) + s.Substring(0, nr + 1);
			return true;
			#endregion
		}

		private void dsphf(string s, string m) {
			Console.WriteLine("------ " + m + " size " + s.Length);
			Console.WriteLine(s);
		}

		private void exchOne(string s) {
			this.dsphf(s, "org");

			if(this.rowExch(ref s))
				this.dsphf(s, "new");
		}

		public void exchAra() {
			this.exchOne("مسلسل خاص من NET-FLIX");
			this.exchOne("مسلسل خاص من NET-FLIX ");
			this.exchOne("مسلسل خاص من  NET-FLIX");
			this.exchOne("NET FLIX " + "مسلسل خاص من");
			this.exchOne("NET FLIX  " + "مسلسل خاص من");
			this.exchOne(" NETFLIX " + "مسلسل خاص من");
		}
		#endregion

		#region NPV
		private void timetype(string s) {
			Regex regex = new Regex("([0-9]):([0-5][0-9])");
			Console.WriteLine("[" + s + "] " + regex.IsMatch(s));
		}
		public void timecheck() {
			this.timetype("aaabbbccc");
			this.timetype("aaa2:300");
			this.timetype("aaa 2:30 ccc");
			this.timetype("aaa 2:30:55 ccc");
			this.timetype("aaa 22:30:55 ccc");
			this.timetype("aaa 2:30:55 33:55 ccc");
			this.timetype("aaa2:3");
			this.timetype("aaa2:3aaa");
		}

		private void decimaltype(string s) {
			Regex regex = new Regex("([0-9])\\.([0-9])");
			Console.WriteLine("[" + s + "] " + regex.IsMatch(s));
		}
		public void decimalcheck() {
			this.decimaltype("aaabbbccc");
			this.decimaltype("aaa2.300");
			this.decimaltype("aaa2 300");
			this.decimaltype("aaa 2.30 ccc");
			this.decimaltype("aaa 2,30 ccc");
			this.decimaltype("aaa 2.0155 ccc");
			this.decimaltype("aaa 22.30.55 ccc");
			this.decimaltype("aaa 2.30 335.5 ccc");
			this.decimaltype("aaa 2,30 335.5 ccc");
		}

		private void dectype(string s) {
			Regex regex = new Regex("([0-9]),([0-9][0-9][0-9] )");
			Console.WriteLine("[" + s + "] " + regex.IsMatch(s));
		}
		public void deccheck() {
			this.dectype("aaabbbccc");
			this.dectype("aaa2,300");
			this.dectype("aaa2.300");
			this.dectype("aaa 2,30 ccc");
			this.dectype("aaa 2,301 ccc");
			this.dectype("aaa 2.301 ccc");
			this.dectype("aaa 2,0155 ccc");
			this.dectype("aaa 22,30,558 ccc");
			this.dectype("aaa 2,30 330,000 ccc");
		}

		private void perctype(string s, bool space = false) {
			Regex regex = new Regex("([0-9]" + (space ? " " : "") + "%)");
			Console.WriteLine("[" + s + "] " + regex.IsMatch(s));
		}
		public void perccheck() {
			this.perctype("aaabbbccc");
			this.perctype("aaa 1%");
			this.perctype("aaa 11%");
			this.perctype("aaa 123%");
			this.perctype("aaa 22 % 111 ccc");
			this.perctype("aaa 2,30 %ccc");
			Console.WriteLine("---------------------------");
			this.perctype("aaabbbccc", true);
			this.perctype("aaa 1%", true);
			this.perctype("aaa 11%", true);
			this.perctype("aaa 123%", true);
			this.perctype("aaa 22 % 111 ccc", true);
			this.perctype("aaa 2,30 %ccc", true);
		}

		private void currtype(string s, bool space = false) {
			Regex regex = new Regex("([0-9]" + (space ? " " : "") + "\\$)");
			Console.WriteLine("[" + s + "] " + regex.IsMatch(s));
		}
		public void curencycheck() {
			this.currtype("aaabbbccc");
			this.currtype("aaa 1$");
			this.currtype("aaa 11$");
			this.currtype("aaa 123$");
			this.currtype("aaa 22 $ 111 ccc");
			this.currtype("aaa 2,30 $ccc");
			Console.WriteLine("---------------------------");
			this.currtype("aaabbbccc", true);
			this.currtype("aaa 1$", true);
			this.currtype("aaa 11$", true);
			this.currtype("aaa 123$", true);
			this.currtype("aaa 22 $ 111 ccc", true);
			this.currtype("aaa 2,30 $ccc", true);
		}

		private void omittype(string s) {
			Regex regex = new Regex("( ,[0-9])");
			Console.WriteLine("[" + s + "] " + regex.IsMatch(s));
		}
		public void Omitcheck() {
			this.omittype("aaabbbccc");
			this.omittype("aaa 111");
			this.omittype("aaa ,11$");
			this.omittype("aaa 1,23$");
			this.omittype("aaa ,22 $ ,111 ccc");
			this.omittype("aaa 2,30 $ccc");
		}

		private void kmtype(string s) {
			Regex r1 = new Regex("([0-9] kms)"), r2 = new Regex("([0-9] hs)");
			Console.WriteLine("[" + s + "] kms(" + r1.IsMatch(s) + ") hs(" +
				r2.IsMatch(s) + ")");
		}
		public void kmcheck() {
			this.kmtype("aaa6kma 5 haa");
			this.kmtype("aaa6 km bb 5 hs b 111");
			this.kmtype("aaa6 kmsdfad 5h");
			this.kmtype("aaaa 6 kms 5hs");
			this.kmtype("aaa ,22 $ ,115 hs ccc");
			this.kmtype("aaa 2,30h hs$ccc");
		}

		private void sepatype(string s) {
			Regex rx = new Regex(@"[\x1c]", RegexOptions.IgnorePatternWhitespace |
				RegexOptions.Singleline);

			MatchCollection mx = rx.Matches(s);
			Console.WriteLine("[" + s + "] " + s.Length + " Matches " + mx.Count);
			if(mx.Count > 0)
				for(int i = 0; i < mx.Count; i++)
					Console.WriteLine("  [" + mx[i].Value + "] " + mx[i].Index);
		}
		public void Sepacheck() {
			this.sepatype("620	00330805/00330823	変よね？	＠斜３");
			this.sepatype("620	00330805/00330823	変よね？	＠斜３");
		}
		#endregion

		#region gop
		private void gone(string s) {
			Console.WriteLine("---" + s + "---");
			Regex regex = new Regex(@"\(\d*,?\d*\)");
			MatchCollection ms = regex.Matches(s);
			Console.Write(ms.Count);
			for(int i = 0; i < ms.Count; i++)
				Console.Write("  " + ms[i].Value);
			Console.WriteLine();
		}
		public void gops() {
			this.gone("(100,200)(300,400)(500,600)");
			this.gone("(100,200)(300,400)(500,)");
			this.gone("aa(100,200)(300,400)(500,600)");
			this.gone("(100,200)bb(300,400)(500,600)");
			this.gone("(100,200)22(300,z400)55(500)");
		}
		#endregion

		#region subtitle
		private void dspbin(byte[] b, string s) {
			string m = s + " ";
			for(int i = 0; i < b.Length; i++)
				m += " " + b[i].ToString("x2");
			Console.WriteLine(m);
		}

		private string mat1(string s, int v) {
			return " " + v.ToString("x2") + "-" + new Regex(@"^\x" + v.ToString("x2") + "+").IsMatch(s);
		}
		private string chg1(string s, int v, bool m = false) {
			return new Regex(@"^\x" + v.ToString("x2") + (m ? "+" : "")).Replace(s, "");
		}
		private void cvtone1(byte[] b, string s) {
			Console.WriteLine("------  " + s);
			this.dspbin(b, "before");

			string orig = System.Text.Encoding.Default.GetString(b);
			Console.WriteLine("string  " + orig + this.mat1(orig, 0xff) + this.mat1(orig, 7));

			byte[] snd = System.Text.Encoding.Default.GetBytes(this.chg1(orig, 0xff));
			this.dspbin(snd, "after ");

			snd = System.Text.Encoding.Default.GetBytes(this.chg1(orig, 0xff, true));
			this.dspbin(snd, "after ");

			snd = System.Text.Encoding.Default.GetBytes(this.chg1(orig, 7));
			this.dspbin(snd, "after ");
		}
		public void pac1() {

			byte[] bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			this.cvtone1(bin, "first  test");

			bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			bin[0] = 0xff;
			bin[1] = 0xff;
			this.cvtone1(bin, "second test");

			bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			bin[0] = 7;
			bin[1] = 0xff;
			this.cvtone1(bin, "third test");

			bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			bin[0] = 0xff;
			bin[1] = 7;
			this.cvtone1(bin, "forth test");

			bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			bin[0] = 7;
			bin[1] = 7;
			this.cvtone1(bin, "fifth test");
		}

		private void dsps(string s, string m) {
			this.dspbin(System.Text.Encoding.Default.GetBytes(s), m);
		}
		private string chg2(string s, string v1, string v2, string m) {
			s = new Regex(v1).Replace(s, v2);
			this.dsps(s, m);
			return s;
		}
		private void cvtone2(byte[] b, string s) {
			Console.WriteLine("------  " + s);
			this.dspbin(b, "before");

			string a = System.Text.Encoding.Default.GetString(b);

			a = this.chg2(a, "\xff", "\x07", "after1");

			a = this.chg2(a, "\x07", "\x08", "after2");

			a = this.chg2(a, "\x08\xfe", "\xfd\x09", "after3");

			a = this.chg2(a, "\xfd\x09", "\x10", "after5");
		}
		public void pac2() {

			byte[] bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			this.cvtone2(bin, "first  test");

			bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			bin[0] = 0xff;
			bin[1] = 7;
			bin[2] = 0xfe;
			this.cvtone2(bin, "second test");

			bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			bin[1] = 7;
			bin[2] = 0xff;
			bin[3] = 0xfe;
			this.cvtone2(bin, "third test");

			bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			bin[1] = 0xff;
			bin[2] = 7;
			bin[3] = 0xfe;
			this.cvtone2(bin, "forth test");

			bin = new byte[8];
			for(int i = 0; i < 8; i++)
				bin[i] = (byte)(i + 0x61);
			bin[4] = 0xff;
			bin[5] = 0xff;
			bin[6] = 7;
			bin[7] = 0xfe;
			this.cvtone2(bin, "fifth test");
		}

		private bool schone(string s) {
			bool ret = new Regex("\x61|\x62|" +
				"\x63").IsMatch(s) && s.Length > 7;
			Console.WriteLine("[" + s + "] " + ret);
			return ret;
		}
		private bool schbuf(byte[] b) {
			return this.schone(System.Text.Encoding.Default.GetString(b));
		}
		public void sch() {
			byte[] b = new byte[8];
			for(int i = 0; i < 8; i++)
				b[i] = (byte)(0x61 + i);
			this.schbuf(b);

			b[1] = 0x42;
			b[2] = 0x43;
			this.schbuf(b);

			b[0] = 0x41;
			b[1] = 0x62;
			this.schbuf(b);

			b[1] = 0x42;
			b[2] = 0x63;
			this.schbuf(b);

			b[2] = 0x42;
			this.schbuf(b);

			b[5] = 0x63;
			this.schbuf(b);
		}
		#endregion

		#region joint
		private string largen(string s) {
			string[] ss = s.Split(',');
			if(ss.Length < 1)
				return s;

			string sn = String.Empty;
			for(int i = 0; i < ss.Length; i++)
				sn += ss[ss.Length - 1 - i] + (i + 1 == ss.Length ? "" : ",");
			return sn;
		}
		private void joinone(string s) {
			MatchCollection mc = new Regex(@"(\d+,)+\d+").Matches(s);
			Console.WriteLine("=== [" + s + "] ===");
			for(int i = 0; i < mc.Count; i++)
				Console.Write("  " + mc[i].Value + " " +
					this.largen(mc[i].Value) + " (" + mc[i].Length + ") ");
			Console.WriteLine();
		}
		public void joins() {
			this.joinone("abcde");
			this.joinone("aaa22bbb");
			this.joinone("aaa33,3bbb");
			this.joinone("aaa55,555,555,555bbb");
			this.joinone("aaa6,6,66666,6bbb");
			this.joinone("aaa77,777bbb ccc88,888ddd9,909");
			this.joinone("aaa77,777bbb ccc88,888ddd9,909eee");
		}

		private void mone_old(string s) {
			Match m = new Regex("[a-zA-Z]+").Match(s);
			string ws = String.Empty;
			int n = -1;

			if(m.Success) {
				ws = s.Substring(m.Index);
				s = s.Substring(0, m.Index);
			}
			if(!Int32.TryParse(s, out n))
				n = -1;

			Console.WriteLine("{" + s + "} === <" + n + "> ws <" + ws + ">");
		}
		private void mone(string s) {
			Match m = new Regex("[^0-9]").Match(s);
			Console.WriteLine("{" + s + "} === " + (m.Success ? "String" : "Number"));
		}
		public void mtest() {
			this.mone("222");
			this.mone("0A");
			this.mone("123AB");
			this.mone("123AB222CD");
			this.mone("12-222");
			this.mone("123-222C");
		}
		#endregion

		#region pac
		private string Revd(string s) {
			char[] cArray = s.ToCharArray();
			Array.Reverse(cArray);
			return new string(cArray);
		}
		private string ReverseDigits(string s) {

			string sRem = s, sNew = String.Empty, sPre, sMtc, sPst;
			Match mt;
			int n = 0;

			while((mt = Regex.Match(sRem, @"\d+(\:\d+|\-\d+)?")).Success) {

				sPre = sRem.Substring(0, mt.Index);
				sMtc = sRem.Substring(mt.Index, mt.Length);
				sPst = sRem.Substring(mt.Index + mt.Length);

				Console.WriteLine("- sPre [" + sPre + "] sMtc [" + sMtc + "] sPst [" + sPst + "]");
				if(n++ > 10)
					break;

				//if(!Regex.IsMatch(sPre, @"[A-Za-z]\s?\-?\""?") &&
				//    !Regex.IsMatch(sPst, @"\s?\-?\""?[A-Za-z]"))
				//sMtc = this.Revd(sMtc);
				if(!(new Regex(@"[A-Za-z]\s?\-?\""?").IsMatch(sPre)) &&
					!(new Regex(@"\s?\-?\""?[A-Za-z]").IsMatch(sPst)))
					sMtc = this.Revd(sMtc);

				sNew += sPre + sMtc;
				sRem = sPst;
				Console.WriteLine("  sNew [" + sNew + "] sRem [" + sRem + "]");
			}

			return sNew + sRem;
		}
		public void rev() {
			string s = "s1 36 minut in 15 sekund,";
			Console.WriteLine("Before [" + s + "]");
			s = this.ReverseDigits(s);
			Console.WriteLine(" After [" + s + "]");
		}

		private void enone(string s) {
			byte[] nb = System.Text.Encoding.GetEncoding("iso-8859-1").GetBytes(s);
			Console.Write("[" + s + "] ");
			for(int i = 0; i < nb.Length; i++)
				Console.Write(" " + nb[i].ToString("x2"));
			Console.WriteLine();
		}
		public void ens() {
			this.enone("\xe5\x41");
			this.enone("\x5c");
		}

		private void eone(string s) {
			string r = "^[a-zA-Z ]+$", d = "^[0-9][0-9,]+[0-9]$";
			Console.WriteLine("[" + s + "] " + new Regex(r).Match(s).Success
				+ " " + new Regex(d).Match(s).Success);
		}
		public void eall() {
			this.eone("test PAC");
			this.eone("test PAC 23432");
			this.eone(" test AAA");
			this.eone(" test BBB");
			this.eone("text PA1C");
			this.eone("123456");
			this.eone("12345,6 ");
			this.eone("123,44,2");
			this.eone("234, 456");
			this.eone("1a345,6");
			this.eone("12345,6,");
			this.eone(",12345,6,");
		}

		private void brone_old(string s) {
			byte[] mb = Encoding.GetEncoding("iso-8859-1").GetBytes(s);
			foreach(byte b in mb)
				Console.Write(b.ToString("x2") + " ");
			Console.WriteLine();
			mb = Encoding.Unicode.GetBytes(s);
			foreach(byte b in mb)
				Console.Write(b.ToString("x2") + " ");
			Console.WriteLine();
			string s1 = Encoding.GetEncoding("iso-8859-1").GetString(mb);
			s1 = s;
			//    Encoding.Unicode.GetBytes(s));
			//string s1 = Encoding.GetEncoding("iso-8859-1").GetString(
			//    Encoding.Unicode.GetBytes(s));
			MatchCollection mc = (new Regex("/((.+)/(")).Matches(s1);
			Console.WriteLine("--- " + s + " --- " + mc.Count);
			if(mc.Count < 1)
				return;
			foreach(Match m in mc)
				Console.WriteLine("  - " + m.Index + " / " + m.Length);
			Console.WriteLine("  Pre  : [" + (mc[0].Index > 0 ? s.Substring(0, mc[0].Index) : "") + "]");
			foreach(Match m in mc)
				Console.WriteLine("       : [" + s.Substring(m.Index, m.Length) + "]");
			Match e = mc[mc.Count - 1];
			Console.WriteLine("  Post : [" + (e.Index + e.Length < s.Length ? s.Substring(e.Index + e.Length) : "") + "]");
		}
		private List<int> iSub(List<int> si) {
			List<int> ns = new List<int>();
			if(si.Count > 0)
				for(int i = 0; i < si.Count - 1; i++)
					ns.Add(si[i]);
			return ns;
		}
		private void reBracket(byte[] b) {
			List<int> rs = new List<int>();
			for(int i = 0; i < b.Length; i++)
				if(b[i] == 0x28)
					rs.Add(i);
				else if(b[i] == 0x29 && rs.Count > 0) {
					b[i] = 0x28;
					b[rs[rs.Count - 1]] = 0x29;
					rs = iSub(rs);
				}
		}
		private void brone(string s) {
			Console.WriteLine("--- " + s + " --- " + s.Length);
			byte[] mb = Encoding.Unicode.GetBytes(s);
			this.reBracket(mb);
			s = Encoding.Unicode.GetString(mb);
			Console.WriteLine("    " + s + " --- " + s.Length);
		}
		public void brackets() {
			Console.WriteLine("brackets");
			this.brone("aaa(bb(ddd)bb)ccc");
			this.brone("حسنا(سنرى)أكلت خمسين كعكة");
		}
		#endregion

		#region srt
		private void decone(string s) {
			string k = "<(/)?i>";
			Console.WriteLine("{" + s + "} key {" + k + "}");
			MatchCollection ms = new Regex(k).Matches(s);
			Console.WriteLine("-- (" + ms.Count + ") --");

			if(ms.Count < 1) {
				Console.WriteLine(s);
				return;
			}

			if(ms[0].Index > 0)
				Console.Write(s.Substring(0, ms[0].Index));

			for(int i = 0; i < ms.Count; i++) {
				Console.Write(ms[i].Value == StyleKey.italicOn ? "[ION]" : "[IOFF]");
				Console.Write(s.Substring(ms[i].Index + ms[i].Length,
					(i + 1 == ms.Count ? s.Length : ms[i + 1].Index) - ms[i].Index - ms[i].Length));
			}
			Console.WriteLine();
		}
		public void decItalics() {
			this.decone("...như thế này, cuộc gọi<i>Cứu con với</i> và gọi <i>tôi</i> đến");
		}
		#endregion

		#region r2l
		private void rone(string s) {
			//string key = @"\d+(\:\d+|\-\d+)?";
			string key = @"[A-Za-z0-9]+[A-Za-z0-9 -:]*[A-Za-z0-9]+";
			Match mt = Regex.Match(s, key);
			Console.WriteLine("[" + s + "] Success [" + mt.Success + "] Index [" + mt.Index + "]" +
				(mt.Success ? " matched {" + mt.Value + "}" : ""));
		}
		public void rall() {
			this.rone("האם דייוויד PAC test הזכיר אי פעם");
			this.rone("-אנחנ צריכים No  לקבל החלטה.");
			this.rone("-גרג ברוק פרסם עכשיו Hello כתבה,");
			this.rone("-סקרים שפועלים 100,000 לטובתכם?");
			this.rone("-יש לנו כמעט 10.7 אלף צירים.");
			this.rone("-956 זה לא אלף.");
			this.rone("הגדול ביותר 10-20-10  חייב לקבל הכרה...");
			this.rone("למאט סנטוס יש 1,300...");
			this.rone("למושל אריק בייקר יש 1,341 קולות.");
			this.rone("מאחר ש-2,162 קולות");
		}
		#endregion

		#region scc
		private string eNote(string s) {
			MatchCollection ms = (new Regex(@"(C+)")).Matches(s);

			if(ms.Count < 1)
				return s;

			string ns = s.Substring(0, ms[0].Index);
			for(int i = 0; i < ms.Count; i++)
				ns += s.Substring(ms[i].Index, (ms[i].Length + 1) >> 1) +
					s.Substring(ms[i].Index + ms[i].Length, (i + 1 == ms.Count ?
					s.Length : ms[i + 1].Index) - ms[i].Index - ms[i].Length);

			return ns;
		}
		private void enoteone(string s) {
			string m = this.eNote(s);
			Console.WriteLine("[" + s + "](" + s.Length + ") [" +
				m + "](" + m.Length + ")");
		}
		public void eighth() {
			this.enoteone("aaaaaaaaC");
			this.enoteone("aaaaCCaaaaCC");
			this.enoteone("aaaaaaaaCCC");
			this.enoteone("aaaCCaaaaaCCCC");
			this.enoteone("CCCaaaCaaaaaCCCCC");
			this.enoteone("CaaaCCaaaaaCCCCC CC");
		}
		#endregion

		#region smi
		private void mlone(string s) {
			MatchCollection mc = new Regex("<BR>|<BR />").Matches(s.ToUpper());
			Console.Write("[" + s + "] matches[" + mc.Count + "] ");
			for(int i = 0; i < mc.Count; i++)
				Console.Write(" " + mc[i].Index + "/" + mc[i].Length);
			Console.WriteLine();
		}
		public void smiml() {
			this.mlone("<SYNC Start=\"784200\"><P Class=\"PTBR\">aaaaa<br />bbb vvfgfncia.</P></SYNC>");
			this.mlone("I think to miss something<BR>is to hope that it will come back.");
			this.mlone("I think to miss something<BR>is to hope that it <BR>will come back.");
			this.mlone("<P Class=\"ZHCN\">我看着你们<BR>还能看到那两个孩子</P>");
		}
		#endregion

		#region ovr
		private void olone(string s) {
			Console.WriteLine("[" + s + "]");
			try {
				MatchCollection mc = new Regex("//").Matches(s.Trim());
				Console.Write("[" + s + "] matches[" + mc.Count + "] ");
				for(int i = 0; i < mc.Count; i++)
					Console.Write(" " + mc[i].Index + "/" + mc[i].Length);
				Console.WriteLine();
			}
			catch(Exception e) {
				Console.WriteLine(e.Message + e.StackTrace);
			}
		}
		public void ovrml() {
			this.olone("Cantonese//1511");
			this.olone("//Iron Man 2//BD//Feature//NTSC//Cantonese//1511");
		}
		#endregion
	}
}