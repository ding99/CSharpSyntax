using System;

namespace CEnum {

	public class EnumShow {
		public EnumShow() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("< EnumShow >");
		}

		private void toShow(SpclChr s){ Console.WriteLine("  {0}  {0:x}  {1:x}  " + (int)s, s, (int)s); }
		public void dsp(int key) {

			Console.WriteLine("- {0:x}", key);

			switch(key) {
			case (int)SpclChr.SRIGHT:
				toShow(SpclChr.SRIGHT);
				break;
			case (int)SpclChr.SCIRCUP:
				toShow(SpclChr.SCIRCUP);
				break;
			case (int) SpclChr.SASHP:
				toShow(SpclChr.SASHP);
				break;
			}
		}

		public void stt() {

			Console.WriteLine("  value  value:x  (int)v:x  (int)v");

			int k = 0x9130;
			dsp(k);

			string ko = "9131";
			dsp(Convert.ToInt32(ko, 16));

			ko = "913b";
			dsp(Convert.ToInt32(ko, 16));
		}

		public enum SpclChr {
			SRIGHT = 0x9130,
			SCIRCUP = 0x9131,
			SHALF = 0x9132,
			SQUESV = 0x9133,
			STM = 0x9134,
			SMONEYC = 0x9135,
			SMONEYY = 0x9136,
			SMUSIC = 0x9137,
			SADOWN = 0x9138,
			SSPACE = 0x9139,
			SEDOWN = 0x913a,
			SASHP = 0x913b,
			SESHP = 0x913c,
			SISHP = 0x913d,
			SOSHP = 0x913e,
			SUSHP = 0x913f,
		}
	}

	public class Enum2String {
		public Enum2String() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("< Enum2String >");
		}

		private enum Merge {
			Normal = 0,
			Merge20 = 2,
			Merge40 = 2,
			Merge51 = 4,
			Merge71 = 7,
		}

		public void transf() {
			Console.WriteLine("ToString-D / ToString");
			Console.WriteLine("Normal  " + Merge.Normal.ToString("D") + " / " + Merge.Normal.ToString());
			Console.WriteLine("Merge20 " + Merge.Merge20.ToString("D") + " / " + Merge.Merge20.ToString());
			Console.WriteLine("Merge40 " + Merge.Merge40.ToString("D") + " / " + Merge.Merge40.ToString());
			Console.WriteLine("Merge51 " + Merge.Merge51.ToString("D") + " / " + Merge.Merge51.ToString());
			Console.WriteLine("Merge71 " + Merge.Merge71.ToString("D") + " / " + Merge.Merge71.ToString());
		}

	}

	public class EnumParse {
		public EnumParse() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("< EnumParse >");
		}

		private enum Merge {
			Unknown = 0,
			Format1,
			Format2,
			Format3,
			Format4,
			Format5
		}

		private bool isone(int n) {
			foreach(Merge m in Enum.GetValues(typeof(Merge)))
				if((int)m == n)
					return true;
			return false;
		}

		private void parseone(int n) {
			Console.Write($"-- [{n}] : ");
			if(this.isone(n))
				Console.Write($"Found [{(Merge)n}]");
			else
				Console.Write("Not Found");

			Console.WriteLine();
		}

		public void parse() {
			for(int i = -2; i < 8; i++)
				this.parseone(i);
		}

	}

	public class Comma {
		public Comma() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("< Comma >");
		}

		private enum e1 { F1, F2, F3, }
		private enum e2 { G1, G2, G3 }

		public void comp() {
			Console.WriteLine("--- e1 ---");
			foreach(e1 e in Enum.GetValues(typeof(e1)))
				Console.WriteLine(e);

			Console.WriteLine("--- e2 ---");
			foreach(e2 e in Enum.GetValues(typeof(e2)))
				Console.WriteLine(e);
		}

		public enum mode {
			None,
			Above,
			Under,
			Right,
			Left
		}

		public void ecopy() {
			Console.WriteLine("--- ecopy ---");

			mode m1 = mode.Under;
			mode m2 = mode.Left;

			Console.WriteLine($"m1 ({m1})  m2 ({m2})");

			m2 = m1;
			Console.WriteLine($"m1 ({m1})  m2 ({m2})");
		}

		public enum LCode {
			Ansi = 0,
			Arabic,
			Hebrew,
			Russian,
			Baltic,
			Greek,
			Turkish,
			EastEurope,
			None,
		}
		public void inv() {
			Console.WriteLine("-- Names");
			foreach(string s in Enum.GetNames(typeof(LCode)))
				Console.WriteLine(s);
			Console.WriteLine("-- Values");
			foreach(LCode v in Enum.GetValues(typeof(LCode)))
				Console.WriteLine(v);
			Console.WriteLine("-- Name " + Enum.GetName(typeof(LCode), LCode.Russian));

			int v1 = 5, v2 = 15;
			Console.WriteLine("-- v1 " + Enum.IsDefined(typeof(LCode), v1) + ", " + (LCode)v1 + ((LCode)v1));
			Console.WriteLine("-- v2 " + Enum.IsDefined(typeof(LCode), v2) + ", " + (LCode)v2);
		}

		public enum Digit {
			AA,
			BB,
			CC = 6,
			DD,
			EE
		}
		private void dspDigit(Digit d) {
			Console.WriteLine(d + " " + (int)d);
		}
		public void seeDigit() {
			this.dspDigit(Digit.EE);
			this.dspDigit(Digit.DD);
			this.dspDigit(Digit.CC);
			this.dspDigit(Digit.BB);
			this.dspDigit(Digit.AA);
		}
	}

	public class EnumSearch {
		public enum Src {
			SRIGHT = 0x9130,
			SCIRCUP = 0x9131,
			SHALF = 0x9132,
			SQUESV = 0x9133,
			SMONEYC = 0x9135,
			SMONEYY = 0x9136,
			SMUSIC = 0x9137,
			SADOWN = 0x9138,
			SSPACE = 0x9139,
			SEDOWN = 0x913a,
			SASHP = 0x913b,
			SESHP = 0x913c,
			SISHP = 0x913d,
			SOSHP = 0x913e,
			SUSHP = 0x913f,
		}
		public enum Tgt {
			SRIGHT = 0x9130,
			SQUESV = 0x9133,
			STM = 0x9134,
			SMONEYC = 0x9135,
			SMONEYY = 0x9136,
			SMUSIC = 0x9137,
			SSPACE = 0x9139,
			SEDOWN = 0x913a,
			SASHP = 0x913b,
			SESHP = 0x913c,
			SISHP = 0x913d,
		}

		public EnumSearch() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("< Enum Search >");
		}

		public void Parse() {
			Src v1 = Src.SESHP;
			Tgt v2 = Tgt.SMONEYC;

			Console.WriteLine("--- original");
			Console.WriteLine($"    v, v-String, v-String-x, 0:x");
			Console.WriteLine($"v1: {v1}, {v1.ToString()}, {v1.ToString("x")}, " + "{0:x}", (int)v1);
			Console.WriteLine($"v2: {v2}, {v2.ToString()}, {v2.ToString("x")}, " + "{0:x}", (int)v2);

			Console.WriteLine("--- by Parse");
			v2 = (Tgt)Enum.Parse(typeof(Src), v1.ToString());
			Console.WriteLine($"v1: {v1}, {v1.ToString()}, {v1.ToString("x")}, " + "{0:x}", (int)v1);
			Console.WriteLine($"v2: {v2}, {v2.ToString()}, {v2.ToString("x")}, " + "{0:x}", (int)v2);

			v2 = Tgt.SMONEYC;
			Console.WriteLine(Environment.NewLine + "--- original");
			Console.WriteLine($"v1: {v1}, {v1.ToString()}, {v1.ToString("x")}, " + "{0:x}", (int)v1);
			Console.WriteLine($"v2: {v2}, {v2.ToString()}, {v2.ToString("x")}, " + "{0:x}", (int)v2);

			Console.WriteLine("--- by TryParse");
			Enum.TryParse<Tgt>(v1.ToString(), true, out v2);
			Console.WriteLine($"v1: {v1}, {v1.ToString()}, {v1.ToString("x")}, " + "{0:x}", (int)v1);
			Console.WriteLine($"v2: {v2}, {v2.ToString()}, {v2.ToString("x")}, " + "{0:x}", (int)v2);
		}
	}

}
