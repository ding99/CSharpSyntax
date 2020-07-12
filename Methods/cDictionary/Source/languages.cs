using System;
using System.Collections.Generic;

namespace cDictionary {

	public class DRussian {

		public DRussian() {
		}

		#region table string
		//ConversionTables::GetPACLatinAccentedCharacters, for RUSSIAN_CHARSET
		Dictionary<string, string> Accented = new Dictionary<string, string> {
			{"\xc0", "\xe3\xa8"}, // Capital A with grave
			{"\xc1", "\xe2\xa8"}, // Capital A with acute
			{"\xc2", "\xe4\xa8"}, // Capital A with circumflex
			{"\xc3", "\xe0\xa8"}, // Capital A with tilde
			{"\xc4", "\xe5\xa8"}, // Capital A with dieresis
			{"\xc5", "\xe1\xa8"}, // Capital A with ring above
			{"\xc7", "\xe6\xac"}, // Capital C with cedilla
			{"\xc8", "\xe3\xae"}, // Capital E with grave
			{"\xc9", "\xe2\xae"}, // Capital E with acute
			{"\xca", "\xe4\xae"}, // Capital E with circumflex
			{"\xcb", "\xe5\xae"}, // Capital E with dieresis
			{"\xcc", "\xe3\xb4"}, // Capital I with grave
			{"\xcd", "\xe2\xb4"}, // Capital I with acute
			{"\xce", "\xe4\xb4"}, // Capital I with circumflex
			{"\xcf", "\xe5\xb4"}, // Capital I with dieresis
			{"\xd2", "\xe3\xab"}, // Capital O with grave
			{"\xd3", "\xe2\xab"}, // Capital O with acute
			{"\xd4", "\xe4\xab"}, // Capital O with circumflex
			{"\xd5", "\xe0\xab"}, // Capital O with tilde
			{"\xd6", "\xe5\xab"}, // Capital O with dieresis
			{"\xd9", "\xe3\xbf"}, // Capital U with grave
			{"\xda", "\xe2\xbf"}, // Capital U with acute
			{"\xdb", "\xe4\xbf"}, // Capital U with circumflex
			{"\xdc", "\xe5\xbf"}, // Capital U with dieresis
			{"\xdd", "\xe2\xc4"}, // Capital Y with acute
			{"\xe0", "\xe3\xa9"}, // Small a with grave
			{"\xe1", "\xe2\xa9"}, // Small a with acute
			{"\xe2", "\xe4\xa9"}, // Small a with circumflex
			{"\xe3", "\xe0\xa9"}, // Small a with tilde
			{"\xe4", "\xe5\xa9"}, // Small a with dieresis
			{"\xe5", "\xe1\xa9"}, // Small a with ring above
			{"\xe7", "\xe6\xc7"}, // Small c with ring cedilla
			{"\xe8", "\xe3\xc9"}, // Small e with grave
			{"\xe9", "\xe2\xc9"}, // Small e with acute
			{"\xea", "\xe4\xc9"}, // Small e with circumflex
			{"\xeb", "\xe5\xc9"}, // Small e with dieresis
			{"\xec", "\xe3\xcd"}, // Small i with grave
			{"\xed", "\xe2\xcd"}, // Small i with acute
			{"\xee", "\xe4\xcd"}, // Small i with circumflex
			{"\xef", "\xe5\xcd"}, // Small i with dieresis
			{"\xf2", "\xe3\xd4"}, // Small o with grave
			{"\xf3", "\xe2\xd4"}, // Small o with acute
			{"\xf4", "\xe4\xd4"}, // Small o with circumflex
			{"\xf5", "\xe0\xd4"}, // Small o with tilde
			{"\xf6", "\xe5\xd4"}, // Small o with dieresis
			{"\xf9", "\xe3\xda"}, // Small u with grave
			{"\xfa", "\xe2\xda"}, // Small u with acute
			{"\xfb", "\xe4\xda"}, // Small u with circumflex
			{"\xfc", "\xe5\xda"}, // Small u with dieresis
			{"\xfd", "\xe2\xde"}, // Small y with acute
			{"\xff", "\xe5\xde"}, // Small y with dieresis
		};
		#endregion

		#region table int
		//ConversionTables::GetPACLatinAccentedCharacters, for RUSSIAN_CHARSET
		Dictionary<int, byte[]> Accent = new Dictionary<int, byte[]> {
			{0xc0, new byte[]{ 0xe3, 0xa8 }}, // Capital A with grave
			{0xc1, new byte[]{ 0xe2, 0xa8 }}, // Capital A with acute
			{0xc2, new byte[]{ 0xe4, 0xa8 }}, // Capital A with circumflex
			{0xc3, new byte[]{ 0xe0, 0xa8 }}, // Capital A with tilde
			{0xc4, new byte[]{ 0xe5, 0xa8 }}, // Capital A with dieresis
			{0xc5, new byte[]{ 0xe1, 0xa8 }}, // Capital A with ring above
			{0xc7, new byte[]{ 0xe6, 0xac }}, // Capital C with cedilla
			{0xc8, new byte[]{ 0xe3, 0xae }}, // Capital E with grave
			{0xc9, new byte[]{ 0xe2, 0xae }}, // Capital E with acute
			{0xca, new byte[]{ 0xe4, 0xae }}, // Capital E with circumflex
			{0xcb, new byte[]{ 0xe5, 0xae }}, // Capital E with dieresis
			{0xcc, new byte[]{ 0xe3, 0xb4 }}, // Capital I with grave
			{0xcd, new byte[]{ 0xe2, 0xb4 }}, // Capital I with acute
			{0xce, new byte[]{ 0xe4, 0xb4 }}, // Capital I with circumflex
			{0xcf, new byte[]{ 0xe5, 0xb4 }}, // Capital I with dieresis
			{0xd2, new byte[]{ 0xe3, 0xab }}, // Capital O with grave
			{0xd3, new byte[]{ 0xe2, 0xab }}, // Capital O with acute
			{0xd4, new byte[]{ 0xe4, 0xab }}, // Capital O with circumflex
			{0xd5, new byte[]{ 0xe0, 0xab }}, // Capital O with tilde
			{0xd6, new byte[]{ 0xe5, 0xab }}, // Capital O with dieresis
			{0xd9, new byte[]{ 0xe3, 0xbf }}, // Capital U with grave
			{0xda, new byte[]{ 0xe2, 0xbf }}, // Capital U with acute
			{0xdb, new byte[]{ 0xe4, 0xbf }}, // Capital U with circumflex
			{0xdc, new byte[]{ 0xe5, 0xbf }}, // Capital U with dieresis
			{0xdd, new byte[]{ 0xe2, 0xc4 }}, // Capital Y with acute
			{0xe0, new byte[]{ 0xe3, 0xa9 }}, // Small a with grave
			{0xe1, new byte[]{ 0xe2, 0xa9 }}, // Small a with acute
			{0xe2, new byte[]{ 0xe4, 0xa9 }}, // Small a with circumflex
			{0xe3, new byte[]{ 0xe0, 0xa9 }}, // Small a with tilde
			{0xe4, new byte[]{ 0xe5, 0xa9 }}, // Small a with dieresis
			{0xe5, new byte[]{ 0xe1, 0xa9 }}, // Small a with ring above
			{0xe7, new byte[]{ 0xe6, 0xc7 }}, // Small c with ring cedilla
			{0xe8, new byte[]{ 0xe3, 0xc9 }}, // Small e with grave
			{0xe9, new byte[]{ 0xe2, 0xc9 }}, // Small e with acute
			{0xea, new byte[]{ 0xe4, 0xc9 }}, // Small e with circumflex
			{0xeb, new byte[]{ 0xe5, 0xc9 }}, // Small e with dieresis
			{0xec, new byte[]{ 0xe3, 0xcd }}, // Small i with grave
			{0xed, new byte[]{ 0xe2, 0xcd }}, // Small i with acute
			{0xee, new byte[]{ 0xe4, 0xcd }}, // Small i with circumflex
			{0xef, new byte[]{ 0xe5, 0xcd }}, // Small i with dieresis
			{0xf2, new byte[]{ 0xe3, 0xd4 }}, // Small o with grave
			{0xf3, new byte[]{ 0xe2, 0xd4 }}, // Small o with acute
			{0xf4, new byte[]{ 0xe4, 0xd4 }}, // Small o with circumflex
			{0xf5, new byte[]{ 0xe0, 0xd4 }}, // Small o with tilde
			{0xf6, new byte[]{ 0xe5, 0xd4 }}, // Small o with dieresis
			{0xf9, new byte[]{ 0xe3, 0xda }}, // Small u with grave
			{0xfa, new byte[]{ 0xe2, 0xda }}, // Small u with acute
			{0xfb, new byte[]{ 0xe4, 0xda }}, // Small u with circumflex
			{0xfc, new byte[]{ 0xe5, 0xda }}, // Small u with dieresis
			{0xfd, new byte[]{ 0xe2, 0xde }}, // Small y with acute
			{0xff, new byte[]{ 0xe5, 0xde }}, // Small y with dieresis
		};
		#endregion

		private void accOne(int v) {
			byte[] bs = new byte[0];
			if(Accent.ContainsKey(v)) bs = Accent[v];
			Console.Write(v.ToString("X2") + " (" + bs.Length + ")");
			foreach(byte b in bs) Console.Write(" " + b.ToString("x2"));
			Console.WriteLine();
		}

		public bool accMulti() {
			this.accOne(0);
			this.accOne(0x66);
			this.accOne(0xc0);
			this.accOne(0xd0);
			this.accOne(0xee);

			return true;
		}
	}
}