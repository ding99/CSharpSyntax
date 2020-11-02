using System;
using System.Collections.Generic;

namespace CLanguage{

	public class araSeg{
		public bool isAra;
		public string Text;

		public araSeg(){
			this.isAra = false;
			this.Text = String.Empty;
		}
	}

	public class CArabic{
		private bool valid;
		private char[] chsAll, chsDbl, chsSgl;

		private void define() {
			this.chsAll = new char[] {
				' ','!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/',
				'\u0660','\u0661','\u0662','\u0663','\u0664','\u0665','\u0666','\u0667',
				'\u0668','\u0669',':',';','<','=','>','?',
				'0','1','2','3','4','5','6','7','8','9',
				'@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O',
				'P','Q','R','S','T','U','V','W','X','Y','Z','[','\\',']','^','_',
				'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o',
				'p','q','r','s','t','u','v','w','x','y','z','{','|','}','~',
				'\u00a0','\u00a4','\u060c','\u00ad','\u061b','\u061f',
				'\u0621','\u0622','\u0623','\u0624','\u0625','\u0626','\u0627',
				'\u0628','\u0629','\u062a','\u062b','\u062c','\u062d','\u062e','\u062f',
				'\u0630','\u0631','\u0632','\u0633','\u0634','\u0635','\u0636','\u0637',
				'\u0638','\u0639','\u063a',
				'\u0640','\u0641','\u0642','\u0643','\u0644','\u0645','\u0646','\u0647',
				'\u0648','\u0649','\u064a','\u064b','\u064c','\u064d','\u064e','\u064f',
				'\u0650','\u0651','\u0652',
			};
			this.chsDbl = new char[] {
				'\u0660','\u0661','\u0662','\u0663','\u0664','\u0665','\u0666','\u0667',
				'\u0668','\u0669','\u060c','\u061b','\u061f',
				'\u0621','\u0622','\u0623','\u0624','\u0625','\u0626','\u0627',
				'\u0628','\u0629','\u062a','\u062b','\u062c','\u062d','\u062e','\u062f',
				'\u0630','\u0631','\u0632','\u0633','\u0634','\u0635','\u0636','\u0637',
				'\u0638','\u0639','\u063a',
				'\u0640','\u0641','\u0642','\u0643','\u0644','\u0645','\u0646','\u0647',
				'\u0648','\u0649','\u064a','\u064b','\u064c','\u064d','\u064e','\u064f',
				'\u0650','\u0651','\u0652','\u200e','\u200f',
			};
			this.chsSgl = new char[] {
				' ','!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/',
				':',';','<','=','>','?',
				'0','1','2','3','4','5','6','7','8','9',
				'@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O',
				'P','Q','R','S','T','U','V','W','X','Y','Z','[','\\',']','^','_',
				'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o',
				'p','q','r','s','t','u','v','w','x','y','z','{','|','}','~',
				'\u00a0','\u00a4','\u00ad',
			};
		}

		public CArabic() {
			this.valid = false;

			this.chsDbl = new char[0];
			this.chsSgl = new char[0];
			this.chsAll = new char[0];

			try {
				this.define();
				this.valid = true;
			}
			catch(Exception) {
				this.valid = false;
			}
		}

		public bool Valid() {
			return this.valid;
		}

		public bool halfAra(char c) {
			for(int i = 0; i < this.chsSgl.Length; i++)
				if(c == this.chsDbl[i])
					return true;
			return false;
		}
		public bool sglAra(string s) {
			for(int i = 0; i < s.Length; i++)
				if(!this.halfAra(s[i]))
					return false;
			return true;
		}

		public bool isAra(char c) {
			for(int i = 0; i < this.chsDbl.Length; i++)
				if(c == this.chsDbl[i])
					return true;
			return false;
		}

		public List<araSeg> isAra(string s) {
			List<araSeg> ss = new List<araSeg>();
			araSeg seg = new araSeg();
			string con = String.Empty;
			bool ara = false;

			for(int i = 0; i < s.Length; i++) {
				if(i == 0){
					con += s[i];
					ara = this.isAra(s[i]);
					continue;
				}

				if(this.isAra(s[i])) {
					if(ara) con += s[i];
					else {
						if(!String.IsNullOrWhiteSpace(con))
							ss.Add(new araSeg { isAra = false, Text = con });
						con = String.Empty;
						con += s[i];
						ara = true;
					}
				} else {
					if(!ara) con += s[i];
					else {
						if(!String.IsNullOrWhiteSpace(con))
							ss.Add(new araSeg { isAra = true, Text = con });
						con = String.Empty;
						con += s[i];
						ara = false;
					}
				}
			}

			if(!String.IsNullOrWhiteSpace(con))
				ss.Add(new araSeg { isAra = ara, Text = con });

			return ss;
		}
	}
}