using System;
using System.Windows.Media;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using CommonLogs;

namespace cStrings {

	public class testJP {

		private CommonLog re;

		public testJP() {
			this.re = new CommonLog(@"D:\workFolder\Santex\chkJP.log", "JP");
		}

		private double width(int c) {
			return (c <= '\u007e' || c == '\u00a5' || c == '\u203e' ||
				(c >= '\uff61' && c <= '\uff9f')) ? .5 : 1;
		}
		private void nChar(string s) {
			string m = "[" + s + "]";
			double size = 0;
			foreach(char c in s) {
				m += " <" + this.width(c) + ">";
				size += this.width(c);
			}
			m += "  {" + size + "}";
			this.re.log(m);
			Console.WriteLine(m);
		}

		public void chkChar() {
			this.nChar("abcd1234 !");
			this.nChar("そんな危険な子をbr");
			this.nChar("ガ56ドルだ");
			this.nChar("今はｱｲｳｴｵ無理ｶｷｸｹｺだろ");
		}

	}

}