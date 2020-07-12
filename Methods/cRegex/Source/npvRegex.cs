using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace cRegex {

	public class Npv {
		public Npv() {
		}

		private bool oneCheck(string s){
			MatchCollection ms = new Regex(@"(\\+)").Matches(s);
			Console.Write("[" + s + "] n (" + ms.Count + ")");
			if(ms.Count < 1)
				return true;

			for(int i = 0; i < ms.Count; i++)
					Console.Write(" " + ms[i].Index + "{" + ms[i].Value + "}" + ms[i].Length);
			Console.WriteLine();

			for(int i = 0; i < ms.Count; i++) {
				if(ms[i].Index == 0) {
					if(ms[i].Length > 2)
						return false;
				}
				else if(ms[i].Length > 1)
					return false;
			}
			
			return true;

		}

		private void oneSlash(string s) {
			bool ret = this.oneCheck(s);
			Console.WriteLine("====== " + ret);
		}

		public void slashes(){
			this.oneSlash(@"\\AAA\BB");
			this.oneSlash(@"\\AAA\\BB");
			this.oneSlash(@"\\\AAA\BB");
			this.oneSlash(@"\\\\AAA\BB");
			this.oneSlash(@"\\AAA\\\\BB");

			this.oneSlash(@"c:\bbb\ccc\dddd\eeeea");
			this.oneSlash(@"c:\\bbb\ccc\dddd\eeeea");
			this.oneSlash(@"c:\\\bbb\ccc\dddd\eeeea");
			this.oneSlash(@"c:\bbb\\ccc\dddd\eeeea");
			this.oneSlash(@"c:\bbb\ccc\dddd\\\eeeea");
		}
	}
}