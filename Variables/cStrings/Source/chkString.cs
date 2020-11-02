using System;
using System.Collections.Generic;

using CommonLogs;

namespace CStrings {
	public class TestString
	{
		#region past
		public TestString()
		{
		}

		public bool timeFormat()
		{

			// to check RFF, DCEU, MSEC, RFF16, fmt23
			string[,] formats = {
				{"NTSC", "29.970", true.ToString()},
				{"NONNTSC", "29.970", false.ToString()},
				{"PAL", "25.000", false.ToString()},
				{"EBU", "25.000", false.ToString()},
				{"BD", "23.976", false.ToString()},
				{"FILM", "24.000", false.ToString()}
			};

			int n = formats.Length;

			Console.WriteLine("nunmer " + n);
			for(int i = 0; i < n / 3; i++)
				Console.WriteLine(formats[i, 0] + "\t" + formats[i, 1] + "\t" + formats[i, 2]);

			return true;
		}

		public bool replace()
		{
			string tnd = "01:00:00:01", td = "01:00:00;02";
			Console.WriteLine("NDrop [" + tnd + "] - [" + tnd.Replace(';', ':') + "]");
			Console.WriteLine("Drop  [" + td + "] - [" + td.Replace(';', ':') + "]");
			return true;
		}

		public bool parastring()
		{
			string tnd = "01:00:00:01";
			int place = tnd.LastIndexOf(":");
			string tndn = tnd.Remove(place, 1).Insert(place, ";");
			Console.WriteLine(tnd + " - " + tndn);
			return true;
		}

		public bool linuxPath()
		{

			string path = "f:\\dir01\\sub02\\file.txt";
			string npath = path.Replace('\\', '/');
			string last = npath;

			if(path.IndexOf(':') == 1)
			{
				char[] chars = npath.Substring(0, 1).ToCharArray();
				int nc = (int)chars[0];
				if((nc > 0x40 && nc < 0x5b) || (nc > 0x60 && nc < 0x7b))
					last = "//localhost/" + npath.Substring(0, 1) + "$" + npath.Substring(2);
			}

			Console.WriteLine("input [" + path + "] " + path.Length);
			Console.WriteLine("last  [" + last + "] " + last.Length);
			return true;
		}

		public bool digits()
		{

			uint v = 0x234bcd;
			Console.WriteLine(v.ToString("x"));
			Console.WriteLine(v.ToString("x8"));
			return true;
		}

		public bool parseInt()
		{
			int n;
			bool ret;

			string val = "125";
			ret = int.TryParse(val, out n);
			Console.WriteLine(val + " - " + n + "; " + ret);

			val = "12a";
			ret = int.TryParse(val, out n);
			Console.WriteLine(val + " - " + n + "; " + ret);
			return true;
		}

		public bool subone()
		{
			string wh = "00:00:20,083 --> 00:00:22,000", pt = " --> ";
			int n = wh.IndexOf(pt);
			Console.WriteLine("[" + wh + "] [" + pt + "] " + n);

			wh = "00:00:20,083 -->00:00:22,000";
			n = wh.IndexOf(pt);
			Console.WriteLine("[" + wh + "] [" + pt + "] " + n);
			return true;
		}

		public void dline(string s)
		{
			Console.WriteLine("org [" + s + "] (" + s.Length + ")");
			string n = s.Replace("\r\n", "");
			Console.WriteLine("new [" + n + "] (" + n.Length + ")");
		}
		public bool newline()
		{
			this.dline("aa" + Environment.NewLine + "bb");
			this.dline(Environment.NewLine + "cc");
			this.dline("dd" + Environment.NewLine);

			return true;
		}
		#endregion

		#region toInt
		private void parse(string name, string s)
		{
			int no;
			Console.WriteLine("- " + name + " [" + s + "]");
			if(s.Substring(0, 1) != "/")
			{
				Console.WriteLine("  Invalid string");
				return;
			}

			Console.WriteLine("  " + (Int32.TryParse(s.Substring(1), out no) ? no.ToString() : "Failed"));

			try
			{
				Console.WriteLine("  " + Int32.Parse(s.Substring(1)));
			}
			catch(Exception e)
			{
				Console.WriteLine("  Parse [" + e.Message + "]");
			}

			try
			{
				Console.WriteLine("  " + Convert.ToInt32(s.Substring(1)));
			}
			catch(Exception e)
			{
				Console.WriteLine("  ToInt32 [" + e.Message + "]");
			}
		}
		public bool conversion()
		{
			this.parse("s1", "/360");
			this.parse("s2", "/360a5");
			this.parse("s3", "abcdsefg");
			return true;
		}
		private int ana(string m)
		{
			try
			{
				string s = m;
				int n;
				if((n = m.IndexOf(",")) != -1)
					s = m.Remove(n, 1).Insert(n, ":");
				string[] r = s.Split(':');
				if(r.Length != 4)
					return -1;
				return ((Int32.Parse(r[0]) * 60 + Int32.Parse(r[1])) * 60 + Int32.Parse(r[2])) * 1000 + Int32.Parse(r[3]);
			}
			catch(Exception)
			{
				return -1;
			}
		}
		public bool split()
		{
			string s = "00:07:57,042 --> 00:08:01,167";
			int n = s.IndexOf("-->");

			Console.WriteLine(s + " n(" + n + ")");

			if(n == -1)
			{
				Console.WriteLine("  failed to devide original string");
				return false;
			}

			string s1 = s.Substring(0, n), s2 = s.Substring(n + 3);
			Console.WriteLine(s1 + ", " + this.ana(s1));
			Console.WriteLine(s2 + ", " + this.ana(s2));

			return true;
		}

		public bool italic0()
		{
			string[] ms, ls = new string[] { "<i>aaaaa</i>", "aaa<i>bbb</i>ccc<i>ddd</i>eee", "<i>bbbb</i>cccc<i>dddd</i>" };
			foreach(string s in ls)
			{
				Console.Write("" + s + " :");
				ms = s.Split('<');
				foreach(string b in ms) Console.Write(" [" + b + "]");
				Console.WriteLine();
			}
			return true;
		}

		private void findone(string s)
		{
			Console.Write(s + " : ");
			int nstt, nend;
			string tstt = s, tend;
			List<string> sl = new List<string>();

			try
			{
				while((nstt = tstt.IndexOf("<i>")) >= 0)
				{
					Console.Write(" " + nstt);
					tend = tstt.Substring(nstt + 3);

					if((nend = tend.IndexOf("</i>")) < 0)
					{
						sl.Add(tstt);
						break;
					}

					if(nstt > 0) sl.Add(tstt.Substring(0, nstt));
					sl.Add(tend.Substring(0, nend) + "-I");

					tstt = tend.Substring(nend + 4);
				}
			}
			catch(Exception c)
			{
				Console.Write(" [" + c.Message + "]");
			}
			Console.WriteLine();

			Console.Write("==");
			foreach(string a in sl)
				Console.Write(" [" + a + "]");
			Console.WriteLine();
		}

		public bool italic()
		{
			string[] ls = new string[] { "<i>aaaaa</i>", "aaa<i>bbb</i>ccc<i>dd23 d</i>eee", "<i>bbbb</i>cccc<i>dddd</i>" };
			foreach(string s in ls) findone(s);
			return true;
		}
		#endregion

		#region seperator
		public class CT
		{
			public int hour;
			public int minute;
			public int second;
			public int msec;

			public CT()
			{
				this.hour = 0;
				this.minute = 0;
				this.second = 0;
				this.msec = 0;
			}

			public CT(int h, int m, int s, int ms)
			{
				this.hour = h;
				this.minute = m;
				this.second = s;
				this.msec = ms;
			}

			public string getString(string sep)
			{
				return string.Format("{0:D2}:{1:D2}:{2:D2}" + sep + "{3:D3}", this.hour, this.minute, this.second, this.msec);
			}
		}
		public bool dspTime()
		{
			CT c = new CT(2, 3, 15, 300);
			Console.WriteLine(c.getString("."));
			Console.WriteLine(c.getString(","));
			return true;
		}
		#endregion

		private void startone(string s)
		{
			Console.WriteLine(s);
			Console.WriteLine("start hyphen " + s.StartsWith("-") + " / period " + s.StartsWith("."));
		}
		public bool startw()
		{
			this.startone("-afezxweaef");
			this.startone("‏‏‎.‎هذه فكرة سيئة‎ -");
			return true;
		}

		private void onelast(string s)
		{
			Console.WriteLine(s + ", " + s.LastIndexOf("."));
		}
		public bool lastindex()
		{
			this.onelast("00:01:43:35");
			this.onelast("00:01:43.210");
			this.onelast("00:01:43,210");
			this.onelast("00:01:43:210");
			this.onelast("00:01:43;35");
			return true;
		}

		public bool tsub()
		{
			string s1 = "00:22:33:22 aaaaaaa", s2 = "00:22:33:22aaaaaaa";
			int i1 = s1.IndexOf(" "), i2 = s2.IndexOf(" ");
			string t1 = String.Empty, t2 = String.Empty;

			if(i1 >= 0)
				t1 = s1.Substring(0, i1);
			if(i2 >= 0)
				t2 = s2.Substring(0, i2);

			Console.WriteLine(s1 + " / " + i1 + " [" + t1 + "]");
			Console.WriteLine(s2 + " / " + i2 + " [" + t2 + "]");
			return true;
		}

		#region hex-byte
		public bool hex2bytes()
		{
			int d = 108;
			Console.WriteLine(d + " / " + d.ToString("X2"));

			byte[] b = System.Text.Encoding.ASCII.GetBytes(d.ToString("X2"));
			foreach(byte o in b)
				Console.Write(o.ToString("x2") + " ");
			Console.WriteLine();

			return true;
		}
		public bool bytes2hex()
		{

			byte[] b = new byte[2];
			b[0] = 0x36;
			b[1] = 0x43;

			foreach(byte o in b)
				Console.Write(o.ToString("x2") + " ");
			Console.WriteLine();

			string s = System.Text.Encoding.ASCII.GetString(b);
			Console.WriteLine("string [" + s + "]");

			int d = 0;
			if(!Int32.TryParse(s, System.Globalization.NumberStyles.HexNumber, null, out d))
				return false;

			Console.WriteLine(d + " / " + d.ToString("X2"));

			Console.WriteLine(Int32.Parse(s, System.Globalization.NumberStyles.HexNumber).ToString("x"));
			return true;
		}
		#endregion

		#region cr
		public bool crs()
		{
			string m = String.Empty;
			Console.WriteLine("string size (" + m.Length + ")");
			m += Environment.NewLine;
			m += Environment.NewLine;
			Console.WriteLine("string size (" + m.Length + ")");

			byte[] b = new byte[m.Length * sizeof(char)];
			System.Buffer.BlockCopy(m.ToCharArray(), 0, b, 0, b.Length);
			Console.WriteLine("byte size (" + b.Length + ")");
			for(int i = 0; i < b.Length; i++)
				Console.Write(b[i].ToString("x2") + " ");
			Console.WriteLine();

			return true;
		}
		#endregion

		#region unicode buffer
		private void dspbuf(string s)
		{
			byte[] b = new byte[s.Length * sizeof(char)];
			System.Buffer.BlockCopy(s.ToCharArray(), 0, b, 0, b.Length);
			Console.WriteLine("[" + s + "] size[" + s.Length + "] buffer size[" + b.Length + "]");
			for(int i = 0; i < b.Length; i++)
				Console.Write(b[i].ToString("x") + " ");
			Console.WriteLine();
		}
		public bool UnicodeBuf()
		{
			Console.WriteLine("char size : " + sizeof(char));
			this.dspbuf("123abc我们");
			return true;
		}
		#endregion

		#region sub digit
		private bool isDgt(char c)
		{
			return c >= '0' && c <= '9';
		}
		private bool isInv(string s, int p, string key)
		{
			if(p < key.Length + 1) return false;
			char c = s[p - key.Length - 1];
			return key.Length > 3 && c != ',';
		}
		private void oneline(string s)
		{
			Console.WriteLine("=== [" + s + "] ===");

			string sc = String.Empty, sd = String.Empty, sub = String.Empty;
			bool dig = false;
			char c;
			int i = 0;
			for(i = 0; i < s.Length; i++)
			{
				if(this.isDgt(c = s[i]))
				{
					if(dig) sd += c;
					else
					{
						sc = String.Empty;
						dig = true;
						sd += c;
					}
				} else if(dig)
				{
					if(this.isInv(s, i, sd))
						Console.WriteLine("  Found [" + sd + "]");
					sd = String.Empty;
					dig = false;
					sc += c;
				} else
					sc += c;
			}
			if(!String.IsNullOrWhiteSpace(sd) && this.isInv(s, i, sd))
				Console.WriteLine("  Found [" + sd + "]");
			Console.WriteLine();
		}
		public bool subDigit()
		{
			this.oneline("aaa22232bbb");
			this.oneline("aaa22 22bbb");
			this.oneline("aag23442,222 bbb");
			this.oneline("aaa222,6666bbb");
			return true;
		}
		#endregion

		#region full-width char
		private void oneTest(string s)
		{
			int nhalf = 0, nfull = 0;
			foreach(char sc in s)
				if(Convert.ToInt32(sc) < 127)
					nhalf++;
				else nfull++;
			Console.WriteLine("[" + s + "] half " + nhalf + " / full " + nfull);
		}
		public bool fullhalf()
		{
			this.oneTest("私は彼らにスカウトされ	");
			this.oneTest("Lambda字幕V4	DF0+1	SCENE\"和文標準\"");
			this.oneTest("10年だ");
			this.oneTest("お２人の関係を");
			return true;
		}
		#endregion

		#region arrow
		private void oneArrowLine(string s)
		{
			Console.Write("[" + s + "] ");
			foreach(char c in s)
			{
				Console.Write("<" + c + ">");
				if(c == '\u2190') Console.Write("[LEFT]");
				else if(c == '\u2191') Console.Write("[UP]");
				else if(c == '\u2192') Console.Write("[RIGHT]");
				else if(c == '\u2193') Console.Write("[DOWN]");
			}
			Console.WriteLine();
		}
		public void arrows()
		{
			this.oneArrowLine("aa← afadfad");
			this.oneArrowLine("ccc↓↓vv→afda↑fd");
		}
		#endregion

		#region upperc
		private void oneupp(string s)
		{
			Console.WriteLine("[" + s + "]  upper[" + s.ToUpper() + "] isUpper " + (s == s.ToUpper()));
		}
		public void uppcheck()
		{
			this.oneupp("Acho que não deveríamos…");
			this.oneupp("(FN) ENTRADA PROIBIDA");
			this.oneupp("Creo que no deberíamos…");
			this.oneupp("(FN) PROHIBIDA LA ENTRADA");
			this.oneupp("Jeg tror ikke, vi bør...");
			this.oneupp("(FN) ADGANG FORBUDT");
			this.oneupp("Ik denk niet…");
			this.oneupp("(FN) VERBODEN TOEGANG");
			this.oneupp("…dat we verder moeten gaan.");
		}
		#endregion

		#region tsf
		private void oneSplit(string s)
		{
			Console.WriteLine("[" + s + "] " + s.Split('|').Length);
		}
		public bool splits()
		{
			this.oneSplit("aaa");
			this.oneSplit("aaa|aa");
			this.oneSplit("aaa|bb|cc");
			this.oneSplit("aaa | a");
			return true;
		}
		#endregion

		#region index
		private void ind(string s)
		{
			Console.WriteLine("--- [" + s + "] ---");
			string k = "";
			Console.WriteLine("  " + (k = "]") + " " + s.IndexOf(k));
			Console.WriteLine("  " + (k = ";") + " " + s.IndexOf(k));
			Console.WriteLine("  " + (k = ",") + " " + s.IndexOf(k));
			Console.WriteLine("  " + (k = ";|]") + " " + s.IndexOf(k));
		}
		public bool indx()
		{
			this.ind("aaa]bbb");
			this.ind("aaa;bbb");
			this.ind("aaa,bbb");
			this.ind("aaa bbb");
			return true;
		}
		#endregion

		#region mapping
		private void pone(string s)
		{
			int? snum = 0;
			int num = 0;
			string slab = String.Empty;

			Console.WriteLine("=== {" + s + "} ===");
			string[] ss = s.Substring(1, s.Length - 2).Split('|');

			string m = String.Empty;
			foreach(string v in ss)
				Console.WriteLine("{" + v + "}");

			if(ss.Length != 3) return;

			int n = 0;
			snum = Int32.TryParse(ss[1], out n) ? (int?)n : null;

			long n3 = 0;
			slab = String.Empty;
			if(Int64.TryParse(ss[2], out n3) && n3 > 0)
			{
				Console.WriteLine("n3 [" + n3.ToString("x") + "]");
				for(int i = 0; i < 8; i++)
					if((n = (int)((n3 >> (56 - i * 8)) & 255)) != 0)
					{
						Console.WriteLine("   " + n);
						slab += (char)n;
					} else if(!String.IsNullOrWhiteSpace(slab)) slab += " ";
			}

			Console.WriteLine(slab);
			num = Int32.TryParse(ss[0], out n) ? n : 0;
			Console.WriteLine(num);
		}
		public bool parseUtf()
		{
			this.pone("[2|1|16705]");
			this.pone("[3|1|65]");
			this.pone("[1]");
			return true;
		}

		private void geneOne(string s)
		{
			long n = 0;
			for(int i = 0; i < s.Length; i++)
				n = (n << 8) + (int)s[i];
			Console.WriteLine("{" + s + "} " + n);
		}
		public bool geneUtf()
		{
			this.geneOne("A");
			this.geneOne("AA");
			this.geneOne("ZA");
			return true;
		}

		public bool chinint()
		{
			char s = 'A';
			long n = (long)s;

			Console.WriteLine(s + ",  int " + n);

			return true;
		}
		#endregion
	}
}
