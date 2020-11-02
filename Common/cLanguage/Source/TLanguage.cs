using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CLanguage
{
	public class TLanguage
	{

		#region arabic
		private static string khalf = "[ !\"#$%&\'()*+,-./:;<=>?0123456789@[\\]^_{|}~]+";
		private static string kreal = "[ !#$%&\'()*+,-./:;<=>?0123456789@[\\]^_{|}~]+";
		private static string kfull = "(['\u0660','\u0661','\u0662','\u0663','\u0664','\u0665','\u0666','\u0667','\u0668','\u0669','\u060c','\u061b','\u061f','\u0621','\u0622','\u0623','\u0624','\u0625','\u0626','\u0627','\u0628','\u0629','\u062a','\u062b','\u062c','\u062d','\u062e','\u062f','\u0630','\u0631','\u0632','\u0633','\u0634','\u0635','\u0636','\u0637','\u0638','\u0639','\u063a','\u0640','\u0641','\u0642','\u0643','\u0644','\u0645','\u0646','\u0647','\u0648','\u0649','\u064a','\u064b','\u064c','\u064d','\u064e','\u064f','\u0650','\u0651','\u0652','\u200e','\u200f'])+";
		#endregion

		private CommonLogs.CommonLog re;

		public TLanguage()
		{
			this.re = new CommonLogs.CommonLog(@"D:\workFolder\Santex\san.log", "");
		}

		#region lanuage detection
		private void detect(string s)
		{
			string regCH = @"^[\u4E00-\u9FA5\s]+$";
			//string regEN = @"^[\W]+$";
			string regEN = @"^([\u00C0-\u01FFa-zA-Z0-9 '])+$";
			string regAR = @"([\u0600-\u06ff][\u0750-\u077f][\ufb50-\ufc3f][\ufe70-\ufefc])+";

			Console.WriteLine();
			Console.WriteLine(s);
			Console.WriteLine((Regex.IsMatch(s, regEN) ? "" : "Not ") + "English");
			Match ma = Regex.Match(s, regAR);
			Console.WriteLine("*** " + (ma.Success ? "" : "Not " + "Arabic ***"));
			Console.WriteLine((Regex.IsMatch(s, regAR) ? "" : "Not ") + "Arabic");
			Console.WriteLine((Regex.IsMatch(s, regCH) ? "" : "Not ") + "Chinese");
		}

		public void whatlang()
		{
			this.detect("Education in School 85 ");
			this.detect("مرحبا! كيف حالكم؟");
			this.detect("用中文表示");
		}
		#endregion

		#region code page
		private void dbin(string s)
		{
			string m = String.Empty;
			byte[] bs = new byte[s.Length * sizeof(char)];
			System.Buffer.BlockCopy(s.ToCharArray(), 0, bs, 0, bs.Length);

			for (int i = 0; i < bs.Length; i++)
				m += (bs[i]).ToString("x") + (i + 1 == bs.Length ? "" : " ");
			Console.WriteLine("[" + m + "] (" + s.Length + ")");
		}
		public void codepage()
		{
			Encoding en = Encoding.GetEncoding(20269);
			Console.WriteLine(en.EncodingName + ", " + en.CodePage + ", " + en.HeaderName);
			Console.WriteLine();

			string s = "Lidi o něm říkali, že je šupák";
			this.dbin(s);

			Console.WriteLine(s + "(" + s.Length + ")");
			byte[] bs = new byte[s.Length * sizeof(char)];
			System.Buffer.BlockCopy(s.ToCharArray(), 0, bs, 0, bs.Length);

			byte[] bn = Encoding.Convert(Encoding.Unicode, en, bs);
			char[] cn = new char[bn.Length / sizeof(char)];
			System.Buffer.BlockCopy(bn, 0, cn, 0, bn.Length);
			string sn = new string(cn);

			Console.WriteLine(sn + "(" + sn.Length + ")");
			this.dbin(sn);
		}

		private void dspch(string s)
		{
			Console.WriteLine("[" + s + "] size(" + s.Length + ")");

			string m = String.Empty;
			for (int i = 0; i < s.Length; i++)
				m += Convert.ToInt32(s[i]).ToString("x") + (i + 1 == s.Length ? "" : " ");
			Console.WriteLine("[" + m + "]");
		}
		public void encoding()
		{
			StreamWriter sw = null;
			try
			{
				FileStream fs = new FileStream(@"d:\workFolder\test1.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
				sw = new StreamWriter(fs);
			}
			catch (Exception)
			{
				return;
			}

			string s = "Lidi o něm říkali, že je šupák,", m = String.Empty;
			Console.WriteLine("-- source");
			this.dspch(s);
			sw.WriteLine("[" + s + "] size(" + s.Length + ")");

			byte[] b = new byte[32768];
			int cn = 0;
			iso6937 fmt = new iso6937();
			if (!fmt.encode(ref b, ref cn, ref m, s))
			{
				Console.WriteLine("message [" + m + "]");
				sw.WriteLine("message [" + m + "]");
			}

			m = "[";
			for (int i = 0; i < cn; i++)
				m += b[i].ToString("x2") + (i + 1 == cn ? "" : " ");
			m += "]";
			Console.WriteLine("-- destination" + Environment.NewLine + m + " (" + cn + ")");
			sw.WriteLine("-- destination" + Environment.NewLine + m + " (" + cn + ")");

			m = String.Empty;
			for (int i = 0; i < cn; i++)
				m += fmt.dec(b, ref i);

			Console.WriteLine("[" + m + "] size(" + m.Length + ")");
			sw.WriteLine("[" + m + "] size(" + m.Length + ")");

			sw.Close();
		}
		#endregion

		#region enc_dec
		public class iso6937
		{

			public class inner
			{
				public byte low8 { get; set; }
				public int ucode { get; set; }
			}

			public class outer
			{
				public byte high { get; set; }
				public inner[] pair { get; set; }
			}

			private char[] tbl;
			private outer[] tbla;

			#region public
			public iso6937()
			{
				#region outer table
				this.tbl = new char[] {
					' ','!','"','#','¤','%','&','\'','(',')','*','+',',','-','.','/',  //2f
					'0','1','2','3','4','5','6','7','8','9',':',';','<','=','>','?',
					'@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O',
						'P','Q','R','S','T','U','V','W','X','Y','Z','[','\\',']','^','_',
					'`','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o',
					'p','q','r','s','t','u','v','w','x','y','z','{','|','}','~',' ',  //7f
					' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',
					' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',
					'\u00a0','\u00a1','\u00a2','\u00a3','$','\u00a5',' ','\u00a7',
					'\u00a4','\u2018','\u201c','\u00ab','\u2190','\u2191','\u2192','\u2193', //af
					//' ','\u2018','\u201c','\u00ab','\u2190','\u2191','\u2192','\u2193', //af
					'\u00b0','\u00b1','\u00b2','\u00b3','\u00d7','\u00b5','\u00b6','\u00b7',
					'\u00f7','\u2019','\u201d','\u00bb','\u00bc','\u00bd','\u00be','\u00bf', //bf
					' ','\u0300','\u0301','\u0302','\u0303','\u0304','\u0306','\u0307',
					'\u0308','\u00c9','\u030a','\u0327','\u2550','\u030b','\u032b','\u030c', //cf
					'\u2015',' ','\u00ae','\u00a9','\u2122','\u266a','\u00ac','\u00a6',
					' ',' ',' ',' ','\u215b','\u215c','\u215d','\u215e', //df
					'\u2126','\u00c6','\u0110','\u00aa','\u0126',' ','\u0132','\u013f',
					'\u0141','\u00db','\u0152','\u00ba','\u00de','\u0166','\u014a','\u0149', //ef
					'\u0138','\u00e6','\u0111','\u00f0','\u0127','\u2513','\u0133','\u0140',
					'\u0142','\u00f8','\u0153','\u00df','\u00fe','\u0167','\u014b','\u00ad' //ff
				};
				#endregion
				#region inner table
				this.tbla = new outer[]{
					new outer(){ high = 0xc1, pair = new inner[]{
						new inner(){ low8 = 0x41, ucode = 0xc0 },
						new inner(){ low8 = 0x45, ucode = 0xc8 },
						new inner(){ low8 = 0x49, ucode = 0xcc },
						new inner(){ low8 = 0x4f, ucode = 0xd2 },
						new inner(){ low8 = 0x55, ucode = 0xd9 },
						new inner(){ low8 = 0x61, ucode = 0xe0 },
						new inner(){ low8 = 0x65, ucode = 0xe8 } ,
						new inner(){ low8 = 0x69, ucode = 0xec },
						new inner(){ low8 = 0x6f, ucode = 0xf2 },
						new inner(){ low8 = 0x75, ucode = 0xf9 }
					}},
					new outer(){ high = 0xc2, pair = new inner[]{
						new inner(){ low8 = 0x20, ucode = 0x0b4 },
						new inner(){ low8 = 0x41, ucode = 0x0c1 },
						new inner(){ low8 = 0x43, ucode = 0x106 },
						new inner(){ low8 = 0x45, ucode = 0x0c9 },
						new inner(){ low8 = 0x49, ucode = 0x0cd },
						new inner(){ low8 = 0x4c, ucode = 0x139 },
						new inner(){ low8 = 0x4e, ucode = 0x143 },
						new inner(){ low8 = 0x4f, ucode = 0x0d3 },
						new inner(){ low8 = 0x52, ucode = 0x154 },
						new inner(){ low8 = 0x53, ucode = 0x15a },
						new inner(){ low8 = 0x55, ucode = 0x0da },
						new inner(){ low8 = 0x59, ucode = 0x0dd },
						new inner(){ low8 = 0x5a, ucode = 0x179 },
						new inner(){ low8 = 0x61, ucode = 0x0e1 },
						new inner(){ low8 = 0x63, ucode = 0x107 },
						new inner(){ low8 = 0x65, ucode = 0x0e9 },
						new inner(){ low8 = 0x69, ucode = 0x0ed },
						new inner(){ low8 = 0x6c, ucode = 0x13a },
						new inner(){ low8 = 0x6e, ucode = 0x144 },
						new inner(){ low8 = 0x6f, ucode = 0x0f3 },
						new inner(){ low8 = 0x72, ucode = 0x155 },
						new inner(){ low8 = 0x73, ucode = 0x15b },
						new inner(){ low8 = 0x75, ucode = 0x0fa },
						new inner(){ low8 = 0x79, ucode = 0x0fd },
						new inner(){ low8 = 0x7a, ucode = 0x17a }
					}},
					new outer(){ high = 0xc3, pair = new inner[]{
						new inner(){ low8 = 0x41, ucode = 0x0c2 },
						new inner(){ low8 = 0x43, ucode = 0x108 },
						new inner(){ low8 = 0x45, ucode = 0x0ca },
						new inner(){ low8 = 0x47, ucode = 0x11c },
						new inner(){ low8 = 0x48, ucode = 0x124 },
						new inner(){ low8 = 0x49, ucode = 0x0ce },
						new inner(){ low8 = 0x4a, ucode = 0x134 },
						new inner(){ low8 = 0x4f, ucode = 0x0d4 },
						new inner(){ low8 = 0x53, ucode = 0x15c },
						new inner(){ low8 = 0x55, ucode = 0x0db },
						new inner(){ low8 = 0x57, ucode = 0x174 },
						new inner(){ low8 = 0x59, ucode = 0x176 },
						new inner(){ low8 = 0x61, ucode = 0x0e2 },
						new inner(){ low8 = 0x63, ucode = 0x109 },
						new inner(){ low8 = 0x65, ucode = 0x0ea },
						new inner(){ low8 = 0x67, ucode = 0x11d },
						new inner(){ low8 = 0x68, ucode = 0x125 },
						new inner(){ low8 = 0x69, ucode = 0x0ee },
						new inner(){ low8 = 0x6a, ucode = 0x135 },
						new inner(){ low8 = 0x6f, ucode = 0x0f4 },
						new inner(){ low8 = 0x73, ucode = 0x15d },
						new inner(){ low8 = 0x75, ucode = 0x0fb },
						new inner(){ low8 = 0x77, ucode = 0x175 },
						new inner(){ low8 = 0x79, ucode = 0x177 },
					}},
					new outer(){ high = 0xc4, pair = new inner[]{
						new inner(){ low8 = 0x41, ucode = 0x0c3 },
						new inner(){ low8 = 0x49, ucode = 0x128 },
						new inner(){ low8 = 0x4e, ucode = 0x0d1 },
						new inner(){ low8 = 0x4f, ucode = 0x0d5 },
						new inner(){ low8 = 0x55, ucode = 0x168 },
						new inner(){ low8 = 0x61, ucode = 0x0e3 },
						new inner(){ low8 = 0x69, ucode = 0x129 },
						new inner(){ low8 = 0x6e, ucode = 0x0f1 },
						new inner(){ low8 = 0x6f, ucode = 0x0f5 },
						new inner(){ low8 = 0x75, ucode = 0x169 },
					}},
					new outer(){ high = 0xc5, pair = new inner[]{
						new inner(){ low8 = 0x20, ucode = 0x0af },
						new inner(){ low8 = 0x41, ucode = 0x100 },
						new inner(){ low8 = 0x45, ucode = 0x112 },
						new inner(){ low8 = 0x49, ucode = 0x12a },
						new inner(){ low8 = 0x4f, ucode = 0x14c },
						new inner(){ low8 = 0x55, ucode = 0x16a },
						new inner(){ low8 = 0x61, ucode = 0x101 },
						new inner(){ low8 = 0x65, ucode = 0x113 },
						new inner(){ low8 = 0x69, ucode = 0x12b },
						new inner(){ low8 = 0x6f, ucode = 0x14d },
						new inner(){ low8 = 0x75, ucode = 0x16b },
					}},
					new outer(){ high = 0xc6, pair =  new inner[]{
						new inner(){ low8 = 0x20, ucode = 0x2d8 },
						new inner(){ low8 = 0x41, ucode = 0x102 },
						new inner(){ low8 = 0x47, ucode = 0x11e },
						new inner(){ low8 = 0x55, ucode = 0x16c },
						new inner(){ low8 = 0x61, ucode = 0x103 },
						new inner(){ low8 = 0x67, ucode = 0x11f },
						new inner(){ low8 = 0x75, ucode = 0x16d },
					}},
					new outer(){ high = 0xc7, pair = new inner[]{
						new inner(){ low8 = 0x20, ucode = 0x2d9 },
						new inner(){ low8 = 0x43, ucode = 0x10a },
						new inner(){ low8 = 0x45, ucode = 0x116 },
						new inner(){ low8 = 0x47, ucode = 0x120 },
						new inner(){ low8 = 0x49, ucode = 0x130 },
						new inner(){ low8 = 0x5a, ucode = 0x17b },
						new inner(){ low8 = 0x63, ucode = 0x10b },
						new inner(){ low8 = 0x65, ucode = 0x117 },
						new inner(){ low8 = 0x67, ucode = 0x121 },
						new inner(){ low8 = 0x7a, ucode = 0x17c },
					}},
					new outer(){ high = 0xc8, pair = new inner[]{
						new inner(){ low8 = 0x20, ucode = 0xa8 },
						new inner(){ low8 = 0x41, ucode = 0xc4 },
						new inner(){ low8 = 0x45, ucode = 0xcb },
						new inner(){ low8 = 0x49, ucode = 0xcf },
						new inner(){ low8 = 0x4f, ucode = 0xd6 },
						new inner(){ low8 = 0x55, ucode = 0xdc },
						new inner(){ low8 = 0x59, ucode = 0x178 },
						new inner(){ low8 = 0x61, ucode = 0xe4 },
						new inner(){ low8 = 0x65, ucode = 0xeb },
						new inner(){ low8 = 0x69, ucode = 0xef },
						new inner(){ low8 = 0x6f, ucode = 0xf6 },
						new inner(){ low8 = 0x75, ucode = 0xfc },
						new inner(){ low8 = 0x79, ucode = 0xff },
					}},
					new outer(){ high = 0xca, pair = new inner[]{
						new inner(){ low8 = 0x20, ucode = 0x2da },
						new inner(){ low8 = 0x41, ucode = 0x0c5 },
						new inner(){ low8 = 0x55, ucode = 0x16e },
						new inner(){ low8 = 0x61, ucode = 0x0e5 },
						new inner(){ low8 = 0x75, ucode = 0x16f },
					}},
					new outer(){ high = 0xcb, pair = new inner[]{
						new inner(){ low8 = 0x20, ucode = 0x0b8 },
						new inner(){ low8 = 0x43, ucode = 0x0c7 },
						new inner(){ low8 = 0x47, ucode = 0x122 },
						new inner(){ low8 = 0x4b, ucode = 0x136 },
						new inner(){ low8 = 0x4c, ucode = 0x13b },
						new inner(){ low8 = 0x4e, ucode = 0x145 },
						new inner(){ low8 = 0x52, ucode = 0x156 },
						new inner(){ low8 = 0x53, ucode = 0x15e },
						new inner(){ low8 = 0x54, ucode = 0x162 },
						new inner(){ low8 = 0x63, ucode = 0x0e7 },
						new inner(){ low8 = 0x67, ucode = 0x123 },
						new inner(){ low8 = 0x6b, ucode = 0x137 },
						new inner(){ low8 = 0x6c, ucode = 0x13c },
						new inner(){ low8 = 0x6e, ucode = 0x146 },
						new inner(){ low8 = 0x72, ucode = 0x157 },
						new inner(){ low8 = 0x73, ucode = 0x15f },
						new inner(){ low8 = 0x74, ucode = 0x163 },
					}},
					new outer(){ high = 0xcd, pair = new inner[]{
						new inner(){ low8 = 0x20, ucode = 0x2dd },
						new inner(){ low8 = 0x4f, ucode = 0x150 },
						new inner(){ low8 = 0x55, ucode = 0x170 },
						new inner(){ low8 = 0x6f, ucode = 0x151 },
						new inner(){ low8 = 0x75, ucode = 0x171 },
					}},
					new outer(){ high = 0xce, pair = new inner[]{
						new inner(){ low8 = 0x20, ucode = 0x2db },
						new inner(){ low8 = 0x41, ucode = 0x104 },
						new inner(){ low8 = 0x45, ucode = 0x118 },
						new inner(){ low8 = 0x49, ucode = 0x12e },
						new inner(){ low8 = 0x55, ucode = 0x172 },
						new inner(){ low8 = 0x61, ucode = 0x105 },
						new inner(){ low8 = 0x65, ucode = 0x119 },
						new inner(){ low8 = 0x69, ucode = 0x12f },
						new inner(){ low8 = 0x75, ucode = 0x173 },
					}},
					new outer(){ high = 0xcf, pair = new inner[]{
						new inner(){ low8 = 0x20, ucode = 0x2c7 },
						new inner(){ low8 = 0x43, ucode = 0x10c },
						new inner(){ low8 = 0x44, ucode = 0x10e },
						new inner(){ low8 = 0x45, ucode = 0x11a },
						new inner(){ low8 = 0x4c, ucode = 0x13d },
						new inner(){ low8 = 0x4e, ucode = 0x147 },
						new inner(){ low8 = 0x52, ucode = 0x158 },
						new inner(){ low8 = 0x53, ucode = 0x160 },
						new inner(){ low8 = 0x54, ucode = 0x164 },
						new inner(){ low8 = 0x5a, ucode = 0x17d },
						new inner(){ low8 = 0x63, ucode = 0x10d },
						new inner(){ low8 = 0x64, ucode = 0x10f },
						new inner(){ low8 = 0x65, ucode = 0x11b },
						new inner(){ low8 = 0x6c, ucode = 0x13e },
						new inner(){ low8 = 0x6e, ucode = 0x148 },
						new inner(){ low8 = 0x72, ucode = 0x159 },
						new inner(){ low8 = 0x73, ucode = 0x161 },
						new inner(){ low8 = 0x74, ucode = 0x165 },
						new inner(){ low8 = 0x7a, ucode = 0x17e },
					}}
				};
				#endregion
			}

			public bool encode(ref byte[] b, ref int p, ref string msg, string s)
			{
				msg = String.Empty;

				for (int i = 0; i < s.Length; i++)
					if (!this.enc(ref b, ref p, ref msg, Convert.ToInt32(s[i])) && !String.IsNullOrWhiteSpace(msg))
						return false;
				return true;
			}
			public string dec(byte[] b, ref int p)
			{
				if (p + 1 >= b.Length)
					return String.Empty;

				foreach (outer r in this.tbla)
					if (b[p] == r.high)
					{
						if (++p < b.Length)
							foreach (inner e in r.pair)
								if (b[p] == e.low8)
									return Convert.ToChar(e.ucode).ToString();

						return String.Empty;
					}

				return this.tbl[b[p] - 0x20].ToString();
			}
			private bool enc(ref byte[] b, ref int p, ref string m, int v)
			{
				foreach (outer r in this.tbla)
					foreach (inner e in r.pair)
						if (e.ucode == v)
						{
							if (p + 2 > b.Length)
							{
								m = "Memory (size " + b.Length + " bytes) overflow for encoding";
								return false;
							}
							b[p++] = r.high;
							b[p++] = e.low8;
							return true;
						}

				for (int k = 0; k < this.tbl.Length; k++)
					if (this.tbl[k] == v)
					{
						if (p >= b.Length)
						{
							m = "Memory (size " + b.Length + " bytes) overflow for encoding";
							return false;
						}
						b[p++] = (byte)(k + 0x20);
						return true;
					}
				return false;
			}
			#endregion

		}
		#endregion

		public void int2char()
		{
			Console.WriteLine("size of char : " + sizeof(char));
			int v1 = 0x11b;
			string s = String.Empty + Convert.ToChar(v1);

			using (FileStream fs = new FileStream(@"d:\workFolder\test.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
			using (StreamWriter sw = new StreamWriter(fs))
			{
				sw.WriteLine(s);
				sw.Close();
			}

			this.dbin(s);
			Console.WriteLine("char 0xcf65 [" + Convert.ToChar(v1) + "]");
		}

		#region arabic_code
		private string real(string s)
		{
			MatchCollection mc = (new Regex(kreal)).Matches(s);
			int n = mc.Count;

			if (n < 1) return s;

			if (n == 1 && mc[0].Length == s.Length)
				return String.Empty;

			if (mc[n - 1].Index + mc[n - 1].Length == s.Length)
				s = s.Substring(0, s.Length - mc[n - 1].Length);

			return mc[0].Index == 0 && n > 1 ? s.Substring(mc[0].Length) : s;
		}
		private bool join(string s)
		{
			MatchCollection mc = (new Regex(khalf)).Matches(s);
			if (mc.Count < 1) return false;
			return mc[0].Value == s;
		}
		private void seg(string s)
		{
			this.re.log(s);
			this.re.log("characters " + s.Length);

			MatchCollection mc = (new Regex(kfull)).Matches(s);
			int n = mc.Count;
			if (mc.Count < 1) return;

			List<string> rst = new List<string>();
			string sub = String.Empty, ssub = String.Empty;
			if (mc[0].Index > 0 && !this.join(sub = s.Substring(0, mc[0].Index)))
				rst.Add(sub);
			if (n > 1)
				for (int i = 1; i < n; i++)
					if (mc[i - 1].Index + mc[i - 1].Length < mc[i].Index &&
						!this.join(sub = s.Substring(mc[i - 1].Index + mc[i - 1].Length,
							mc[i].Index - mc[i - 1].Length - mc[i - 1].Index)))
						rst.Add(sub);

			if (mc[n - 1].Index + mc[n - 1].Length < s.Length && !this.join(sub =
				s.Substring(mc[n - 1].Index + mc[n - 1].Length)))
				rst.Add(sub);

			this.re.log("------ " + rst.Count);

			List<string> rl = new List<string>();
			foreach (string r in rst)
				if (!String.IsNullOrWhiteSpace(sub = this.real(r)))
					rl.Add(sub);

			foreach (string r in rl)
				this.re.log("{" + r + "} " + r.Length);
			this.re.log("====== " + rl.Count);
		}

		public void segs()
		{
			Console.WriteLine("segs");
			this.seg("شريك مؤسس لموقع الترفيه‎‏‎،\"Reddit\" ،‎والأخبار الاجتماعية");
			this.seg("شريك مؤسس لموقع الترفيه‎‏‎،Reddit ،‎والأخبار الاجتماعية");
			this.seg("‏‏‏ثمة إحساس عميق بالخسارة‎><‏‎،\"Highland Park\" ‏هذه الليلة في");
			this.seg("،\"‎الزهرة‎\" ‏رمز‎ ،\"‎عطارد‎\" ‏رمز");
			this.seg(".\"Aaron\" ‏المضيف‎ .\"Aaron\" ‏أنا مضيفكم");
			this.seg("اليافع الطائرة إلى‎ \" Aaron Swartz\" ‏ركب‎><‏‎.‎لحضور جلسات المحكمة العليا‎ \"‎واشنطن‎\"");
		}
		#endregion
	}
}
