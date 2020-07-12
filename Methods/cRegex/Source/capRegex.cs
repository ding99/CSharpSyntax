using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace cRegex {

	public class Cap {
		public Cap() {
		}

		private void mone(string s) {
			Console.Write("{" + s + "}");
			Regex r1 = new Regex(@"(\w+)\t(\d*)[\t,/](\d*)\t");
			Regex r2 = new Regex(@"(\w*)\t(\d*)[\t,/](\d*)\t");
			Match m = r2.Match(s);
			if(!m.Success) {
				Console.WriteLine();
				return;
			}

			Console.Write("  value [" + m.Value + "]");
			MatchCollection ms = (new Regex(@"(\w*)[\t,/]")).Matches(m.Value);
			if(ms.Count == 3)
				Console.Write(" [" + ms[0].Value + "] [" + ms[1].Value + "] [" + ms[2].Value + "]");

			Console.WriteLine();
		}
		public void redo() {
			this.mone("1	01003909/01004105	これは新しいぞ	＠斜３");
			this.mone("	01003909/01004105	これは新しいぞ	＠斜３");
		}

		/*** Tate Chu Yoko ***/
		private bool isDgt(char s) {
			for(int i = 0; i < 10; i++)
				if(s.ToString() == i.ToString())
					return true;
			return false;
		}
		private List<int> nChu(string s) {
			List<int> l = new List<int>();
			int p = 0;
			//MatchCollection ms = new Regex(@"([\D]|^)\d{2}(?!\d)").Matches(s);
			MatchCollection ms = new Regex(@"(?<![0-9]|^)[0-9]{2}(?![0-9])").Matches(s);
			Console.Write("[" + s + "]");
			
			for(int i = 0; i < ms.Count; i++) {

				if((p = ms[i].Index + (ms[i].Length == 3 ? 1 : 0)) > 2 &&
					s[p - 1] == '.' && this.isDgt(s[p - 2]))
					continue;
				if((p = ms[i].Index + ms[i].Length) + 2 < s.Length &&
					s[p] == '.' && this.isDgt(s[p + 1]))
					continue;
				if(p + 4 < s.Length && s[p] == ',' &&
					this.isDgt(s[p + 1]) && this.isDgt(s[p + 2]) && this.isDgt(s[p + 3]))
					continue;

				l.Add(ms[i].Index + (ms[i].Length == 3 ? 1 : 0));
			}

			Console.Write("  n (" + l.Count + ")");
			if(l.Count > 0)
				for(int i = 0; i < l.Count; i++)
					Console.Write(" " + l[i] + "{" + s.Substring(l[i], 2) + "}");
			Console.WriteLine();

			return l;
		}

		private void oneChu(string s){
			MatchCollection ms = new Regex(@"([\D]|^)\d{2}(?!\d)").Matches(s);
			Console.Write("[" + s + "] n (" + ms.Count + ")");
			if(ms.Count > 0)
				for(int i = 0; i < ms.Count; i++)
					Console.Write(" " + ms[i].Index + "{" + ms[i].Value + "}" + ms[i].Length);
			Console.WriteLine();
		}

		public void chu(){
			//this.oneChu("aaaaaaaaaa");
			//this.oneChu("afasdf44 23e2 adfadf8afa8");
			//this.oneChu("Mar 25, 1999");
			//this.oneChu("Mar 25, 199pppp222");
			//this.oneChu("25, 199pppp222");
			//this.oneChu("25, 199pppp22");
			//this.oneChu("a25, 199pppp2");
			this.nChu("aaaaaaaaaa");
			this.nChu("afasdf44 23e2 adfadf8afa8");
			this.nChu("Mar 25, 1999");
			this.nChu("Mar 25, 199pppp222");
			this.nChu("25, 199pppp222");
			this.nChu("25, 199pppp22");
			this.nChu("a25, 199pppp2");
			this.nChu("a25, 19.25");
			this.nChu("a25, 19,234ppp");
			this.nChu("a25, 1.99pppp2");
		}
	}
}