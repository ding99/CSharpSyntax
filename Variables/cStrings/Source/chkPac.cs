using System;
using System.Windows.Media;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using CommonLogs;

namespace CStrings {

	public class TestPAC {

		private CommonLog re;

		public TestPAC() {
			this.re = new CommonLog(@"D:\workFolder\Santex\chkPac.log", "PAC");
		}

		private bool isPac(int c) {
			return c < '\u00ff' || c == '\u2018' || c == '\u2019' ||
				c == '\u201c' || c == '\u201d' || c == '\u201e' || c == '\u2026';
		}
		private void nChar(string s) {
			string m = "[" + s + "]";
			int np = 0, pn = 0;
			foreach(char c in s) {
				if(!this.isPac(c)) {
					m += " " + pn;
					np++;
				}
				pn++;
			}
			if(np > 0)
				m += " (" + np + ")";
			this.re.log(m);
			Console.WriteLine(m);
		}

		public void chkChar() {
			this.nChar("abcd1234 !");
			this.nChar("‘’“”„…1234 !");
			this.nChar("Żabińska");
			this.nChar("Ryś");
			this.nChar("Płońsk");
			this.nChar("Führung");
			this.nChar("übernommen");
			this.nChar("Łomża");
			this.nChar("Łódź");
			this.nChar("Żurawia-Straße");
		}

	}

}