using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace cRegex {

	public class Vtt {
		public Vtt() {
		}

		private void one(string s) {
			MatchCollection ms = new Regex(@"<br"+ " *" + "/>").Matches(s);
			Console.Write("[" + s + "] n (" + ms.Count + ")");
			for(int i = 0; i < ms.Count; i++)
				Console.Write(ms[i].Index + "-" + ms[i].Length + " ");
			Console.WriteLine();
		}

		public void lines() {
			this.one("-I've got you.<br />-Don't let go.");
			this.one("-I've got you.<br />-Don't <br  />let <br/>go.");
			this.one("because I plan on using<br />all of the hot water.");
			this.one("-Hi.<br />-Hi.");
			this.one("Hi.<br/>-Hi.");
			this.one("-Hi.<br  />-Hi.");
			this.one("-Hi.-Hi.");
		}
	}
}