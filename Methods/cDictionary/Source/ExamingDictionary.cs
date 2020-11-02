using System;
using System.Collections.Generic;

namespace CDictionary {

	public class ExamingDictionary{
		private Dictionary<uint, string> sdic;

		private void createDict(){
			this.sdic.Add(0, "Item000");
			this.sdic.Add(1, "Item001");
			this.sdic.Add(2, "Item002");
			this.sdic.Add(10, "Item010");
			this.sdic.Add(100, "Item100");

			Console.WriteLine("created dictionary [" + this.sdic.Count + "]");
		}

		public ExamingDictionary(){
			this.sdic = new Dictionary<uint,string>();
			this.createDict();
		}

		private void getone(uint i){
			if(this.sdic.ContainsKey(i))
				Console.WriteLine("  " + i + " [" + this.sdic[i] + "]");
			else
				Console.WriteLine("  " + i + " [not found key]");
		}

		public bool getStr(){
			this.getone(0);
			this.getone(2);
			this.getone(3);
			this.getone(10);
			this.getone(200);
			return true;
		}

		#region direct
		public bool launch() {

			Dictionary<string, string> d = new Dictionary<string, string> {
				{"\x31", "\x61\x62"},
				{"\x32", "\x63\x64"},
				{"\x33", "\x41\x42"},
				{"\x34", "\x43\x44"},
			};

			foreach(var a in d)
				Console.WriteLine(a.Key + " / " + a.Value);

			return true;
		}

		private string s2s(string s) {
			byte[] b = System.Text.Encoding.GetEncoding("iso-8859-1").GetBytes(s);
			string m = "<";
			for(int i = 0; i < b.Length; i++)
				m += b[i].ToString("x2") + (i + 1 == b.Length ? "" : " ");
			return m + ">";
		}
		public bool corrupt() {

			#region table
			Dictionary<string, string> d = new Dictionary<string,string>{
				{ "\xb3"		, "\x22\x00" },	// quotes
				{ "\xa2"		, "\x25\x00" },	// percent
				{ "\xa4"		, "\x26\x00" },	// ampersand
				{ "\xb2"		, "\x27\x00" },	// apostrophe
				{ "\xc1"		, "\x2a\x00" },	// asterisk
				{ "\x5e"		, "\x2c\x00" },	// comma
				{ "\x23"		, "\x2f\x00" },	// slash
				{ "\x25"		, "\x3a\x00" },	// colon
				{ "\x2a"		, "\x3b\x00" },	// semicolon
				{ "\x24"		, "\x3f\x00" },	// question mark
				{ "\x26"		, "\x2e\x00" },	// full stop
				{ "\x2f"		, "\xab\x00" },	// LEFT-POINTING DOUBLE ANGLE QUOTATION MARK
				{ "\x3f"		, "\xbb\x00" },	// RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK
				{ "\x9d"		, "\xa7\x00" },	// section sign
				{ "\xe3\x54"	, "\x00\x04" },	// Capital letter Ie with grave
				{ "\xe5\x54"	, "\x01\x04" },	// Capital letter Io
				{ "\x82"		, "\x02\x04" },	// Capital letter Dje
				{ "\xe2\x55"	, "\x03\x04" },	// Capital letter Gje
				{ "\x84"		, "\x04\x04" },	// Capital letter Ukrainian Ie
				{ "\x85"		, "\x05\x04" },	// Capital letter Dze
				{ "\x86"		, "\x06\x04" },	// Capital letter Byelorussian-Ukrainian I
				{ "\xe5\x86"	, "\x07\x04" },	// Capital letter Yi
				{ "\x88"		, "\x08\x04" },	// Capital letter Je
				{ "\x89"		, "\x09\x04" },	// Capital letter Lje
				{ "\x8a"		, "\x0a\x04" },	// Capital letter Nje
				{ "\x8b"		, "\x0b\x04" },	// Capital letter Tshe
				{ "\xe2\x52"	, "\x0c\x04" },	// Capital letter Kje
				{ "\xe3\x42"	, "\x0d\x04" },	// Capital letter I with grave
				{ "\xe0\x45"	, "\x0e\x04" },	// Capital letter Short U
				{ "\x8f"		, "\x0f\x04" },	// Capital letter Dzhe
				{ "\x46"		, "\x10\x04" },	// Capital letter A
				{ "\x80"		, "\x11\x04" },	// Capital letter Be
				{ "\x44"		, "\x12\x04" },	// Capital letter Ve
				{ "\x55"		, "\x13\x04" },	// Capital letter Ghe
				{ "\x4c"		, "\x14\x04" },	// Capital letter De
				{ "\x54"		, "\x15\x04" },	// Capital letter Ie
				{ "\x3a"		, "\x16\x04" },	// Capital letter Zhe
				{ "\x50"		, "\x17\x04" },	// Capital letter Ze
				{ "\x42"		, "\x18\x04" },	// Capital letter I
				{ "\xe0\x42"	, "\x19\x04" },	// Capital letter Short I
				{ "\xe5\x42"	, "\x19\x04" },	// Capital letter Short I
				{ "\x52"		, "\x1a\x04" },	// Capital letter Ka
				{ "\x4b"		, "\x1b\x04" },	// Capital letter El
				{ "\x56"		, "\x1c\x04" },	// Capital letter Em
				{ "\x59"		, "\x1d\x04" },	// Capital letter En
				{ "\x4a"		, "\x1e\x04" },	// Capital letter O
				{ "\x47"		, "\x1f\x04" },	// Capital letter Pe
				{ "\x48"		, "\x20\x04" },	// Capital letter Er
				{ "\x43"		, "\x21\x04" },	// Capital letter Es
				{ "\x4e"		, "\x22\x04" },	// Capital letter Te
				{ "\x45"		, "\x23\x04" },	// Capital letter U
				{ "\x41"		, "\x24\x04" },	// Capital letter Ef
				{ "\x7b"		, "\x25\x04" },	// Capital letter Ha		
				{ "\x57"		, "\x26\x04" },	// Capital letter Tse
				{ "\x58"		, "\x27\x04" },	// Capital letter Che
				{ "\x49"		, "\x28\x04" },	// Capital letter Sha
				{ "\x4f"		, "\x29\x04" },	// Capital letter Shcha
				{ "\x7d"		, "\x2a\x04" },	// Capital letter Hard Sign
				{ "\x53"		, "\x2b\x04" },	// Capital letter Yeru
				{ "\x4d"		, "\x2c\x04" },	// Capital letter Soft Sign
				{ "\x22"		, "\x2d\x04" },	// Capital letter E
				{ "\x81"		, "\x2e\x04" },	// Capital letter Yu
				{ "\x5a"		, "\x2f\x04" },	// Capital letter Ya
				{ "\x66"		, "\x30\x04" },	// Small letter A
				{ "\x2c"		, "\x31\x04" },	// small letter Be
				{ "\x64"		, "\x32\x04" },	// small letter Ve
				{ "\x75"		, "\x33\x04" },	// small letter Ghe   
				{ "\x6c"		, "\x34\x04" },	// small letter De      
				{ "\x74"		, "\x35\x04" },	// small letter Ie     
				{ "\x3b"		, "\x36\x04" },	// small letter Zhe   
				{ "\x70"		, "\x37\x04" },	// small letter Ze       
				{ "\x62"		, "\x38\x04" },	// small letter I        
				{ "\xe0\x62"	, "\x39\x04" },	// small letter Short I
				{ "\x72"		, "\x3a\x04" },	// small letter Ka      
				{ "\x6b"		, "\x3b\x04" },	// small letter El        
				{ "\x76"		, "\x3c\x04" },	// small letter Em     
				{ "\x79"		, "\x3d\x04" },	// small letter En       
				{ "\x6a"		, "\x3e\x04" },	// small letter O         
				{ "\x67"		, "\x3f\x04" },	// small letter Pe      
				{ "\x68"		, "\x40\x04" },	// small letter Er         
				{ "\x63"		, "\x41\x04" },	// small letter Es         
				{ "\x6e"		, "\x42\x04" },	// small letter Te       
				{ "\x65"		, "\x43\x04" },	// small letter U        
				{ "\x61"		, "\x44\x04" },	// small letter Ef      
				{ "\x5b"		, "\x45\x04" },	// small letter Ha	
				{ "\x77"		, "\x46\x04" },	// small letter Tse    
				{ "\x78"		, "\x47\x04" },	// small letter Che   
				{ "\x69"		, "\x48\x04" },	// small letter Sha        
				{ "\x6f"		, "\x49\x04" },	// small letter Shcha    
				{ "\x5d"		, "\x4a\x04" },	// small letter Hard Sign  
				{ "\x73"		, "\x4b\x04" },	// small letter Yeru  
				{ "\x6d"		, "\x4c\x04" },	// small letter Soft Sign  
				{ "\x27"		, "\x4d\x04" },	// small letter E        
				{ "\x2e"		, "\x4e\x04" },	// small letter Yu   
				{ "\x7a"		, "\x4f\x04" },	// small letter Ya       
				{ "\xe3\x74"	, "\x50\x04" },	// Small letter Ie with grave
				{ "\xe5\x74"	, "\x51\x04" },	// Small letter Io
				{ "\x92"		, "\x52\x04" },	// Small letter Dje
				{ "\xe2\x75"	, "\x53\x04" },	// Small letter Gje
				{ "\x94"		, "\x54\x04" },	// Small letter Ukrainian Ie
				{ "\x95"		, "\x55\x04" },	// Small letter Dze
				{ "\x96"		, "\x56\x04" },	// Small letter Byelorussian-Ukrainian I
				{ "\xe5\x96"	, "\x57\x04" },	// Small letter Yi
				{ "\x98"		, "\x58\x04" },	// Small letter Je
				{ "\x99"		, "\x59\x04" },	// Small letter Lje
				{ "\x9a"		, "\x5a\x04" },	// Small letter Nje
				{ "\x9b"		, "\x5b\x04" },	// Small letter Tshe
				{ "\xe2\x72"	, "\x5c\x04" },	// Small letter Kje
				{ "\xe3\x62"	, "\x5d\x04" },	// Small letter I with grave
				{ "\xe0\x65"	, "\x5e\x04" },	// Small letter Short U
				{ "\x9f"		, "\x5f\x04" },	// Small letter Dzhe
				/*--- Latin characters for Cyrillic --- */
				{ "\xa8"		, "\x41\x00" },	// A
				{ "\xaa"		, "\x42\x00" },	// B
				{ "\xac"		, "\x43\x00" },	// C
				{ "\xad"		, "\x44\x00" },	// D
				{ "\xae"		, "\x45\x00" },	// E
				{ "\xaf"		, "\x46\x00" },	// F
				{ "\xb0"		, "\x47\x00" },	// G
				{ "\xb1"		, "\x48\x00" },	// H
				{ "\xb4"		, "\x49\x00" },	// I
				{ "\xb5"		, "\x4a\x00" },	// J
				{ "\xb6"		, "\x4b\x00" },	// K
				{ "\xb7"		, "\x4c\x00" },	// L
				{ "\xb8"		, "\x4d\x00" },	// M
				{ "\xb9"		, "\x4e\x00" },	// N
				{ "\xab"		, "\x4f\x00" },	// O
				{ "\xba"		, "\x50\x00" },	// P
				{ "\xbb"		, "\x51\x00" },	// Q
				{ "\xbc"		, "\x52\x00" },	// R
				{ "\xbd"		, "\x53\x00" },	// S
				{ "\xbe"		, "\x54\x00" },	// T
				{ "\xbf"		, "\x55\x00" },	// U
				{ "\xc0"		, "\x56\x00" },	// V
				{ "\xc2"		, "\x57\x00" },	// W
				{ "\xc3"		, "\x58\x00" },	// X
				{ "\xc4"		, "\x59\x00" },	// Y
				{ "\xc5"		, "\x5a\x00" },	// Z
				{ "\xa9"		, "\x61\x00" },	// a
				{ "\xc6"		, "\x62\x00" },	// b
				{ "\xc7"		, "\x63\x00" },	// c
				{ "\xc8"		, "\x64\x00" },	// d
				{ "\xc9"		, "\x65\x00" },	// e
				{ "\xca"		, "\x66\x00" },	// f
				{ "\xcb"		, "\x67\x00" },	// g
				{ "\xcc"		, "\x68\x00" },	// h
				{ "\xcd"		, "\x69\x00" },	// i
				{ "\xce"		, "\x6a\x00" },	// j
				{ "\xcf"		, "\x6b\x00" },	// k
				{ "\xd1"		, "\x6c\x00" },	// l
				{ "\xd2"		, "\x6d\x00" },	// m
				{ "\xd3"		, "\x6e\x00" },	// n
				{ "\xd4"		, "\x6f\x00" },	// o
				{ "\xd5"		, "\x70\x00" },	// p
				{ "\xd6"		, "\x71\x00" },	// q
				{ "\xd7"		, "\x72\x00" },	// r
				{ "\xd8"		, "\x73\x00" },	// s
				{ "\xd9"		, "\x74\x00" },	// t
				{ "\xda"		, "\x75\x00" },	// u
				{ "\xdb"		, "\x76\x00" },	// v
				{ "\xdc"		, "\x77\x00" },	// w
				{ "\xdd"		, "\x78\x00" },	// x
				{ "\xde"		, "\x79\x00" },	// y
				{ "\xdf"		, "\x7a\x00" },	// z
				{ "\xe3\xa8"	, "\xc0\x00" },	// Capital A with grave
				{ "\xe2\xa8"	, "\xc1\x00" },	// Capital A with acute
				{ "\xe4\xa8"	, "\xc2\x00" },	// Capital A with circumflex
				{ "\xe0\xa8"	, "\xc3\x00" },	// Capital A with tilde
				{ "\xe5\xa8"	, "\xc4\x00" },	// Capital A with dieresis
				{ "\xe1\xa8"	, "\xc5\x00" },	// Capital A with ring above
				{ "\xe6\xac"	, "\xc7\x00" },	// Capital C with cedilla
				{ "\xe3\xae"	, "\xc8\x00" },	// Capital E with grave
				{ "\xe2\xae"	, "\xc9\x00" },	// Capital E with acute
				{ "\xe4\xae"	, "\xca\x00" },	// Capital E with circumflex
				{ "\xe5\xae"	, "\xcb\x00" },	// Capital E with dieresis
				{ "\xe3\xb4"	, "\xcc\x00" },	// Capital I with grave
				{ "\xe2\xb4"	, "\xcd\x00" },	// Capital I with acute
				{ "\xe4\xb4"	, "\xce\x00" },	// Capital I with circumflex
				{ "\xe5\xb4"	, "\xcf\x00" },	// Capital I with dieresis
				{ "\xe3\xab"	, "\xd2\x00" },	// Capital O with grave
				{ "\xe2\xab"	, "\xd3\x00" },	// Capital O with acute
				{ "\xe4\xab"	, "\xd4\x00" },	// Capital O with circumflex
				{ "\xe0\xab"	, "\xd5\x00" },	// Capital O with tilde
				{ "\xe5\xab"	, "\xd6\x00" },	// Capital O with dieresis
				{ "\xe3\xbf"	, "\xd9\x00" },	// Capital U with grave
				{ "\xe2\xbf"	, "\xda\x00" },	// Capital U with acute
				{ "\xe4\xbf"	, "\xdb\x00" },	// Capital U with circumflex
				{ "\xe5\xbf"	, "\xdc\x00" },	// Capital U with dieresis
				{ "\xe2\xc4"	, "\xdd\x00" },	// Capital Y with acute
				{ "\xe3\xa9"	, "\xe0\x00" },	// Small a with grave
				{ "\xe2\xa9"	, "\xe1\x00" },	// Small a with acute
				{ "\xe4\xa9"	, "\xe2\x00" },	// Small a with circumflex
				{ "\xe0\xa9"	, "\xe3\x00" },	// Small a with tilde
				{ "\xe5\xa9"	, "\xe4\x00" },	// Small a with dieresis
				{ "\xe1\xa9"	, "\xe5\x00" },	// Small a with ring above
				{ "\xe6\xc7"	, "\xe7\x00" },	// Small c with ring cedilla
				{ "\xe3\xc9"	, "\xe8\x00" },	// Small e with grave
				{ "\xe2\xc9"	, "\xe9\x00" },	// Small e with acute
				{ "\xe4\xc9"	, "\xea\x00" },	// Small e with circumflex
				{ "\xe5\xc9"	, "\xeb\x00" },	// Small e with dieresis
				{ "\xe3\xcd"	, "\xec\x00" },	// Small i with grave
				{ "\xe2\xcd"	, "\xed\x00" },	// Small i with acute
				{ "\xe4\xcd"	, "\xee\x00" },	// Small i with circumflex
				{ "\xe5\xcd"	, "\xef\x00" },	// Small i with dieresis
				{ "\xe3\xd4"	, "\xf2\x00" },	// Small o with grave
				{ "\xe2\xd4"	, "\xf3\x00" },	// Small o with acute
				{ "\xe4\xd4"	, "\xf4\x00" },	// Small o with circumflex
				{ "\xe0\xd4"	, "\xf5\x00" },	// Small o with tilde
				{ "\xe5\xd4"	, "\xf6\x00" },	// Small o with dieresis
				{ "\xe3\xda"	, "\xf9\x00" },	// Small u with grave
				{ "\xe2\xda"	, "\xfa\x00" },	// Small u with acute
				{ "\xe4\xda"	, "\xfb\x00" },	// Small u with circumflex
				{ "\xe5\xda"	, "\xfc\x00" },	// Small u with dieresis
				{ "\xe2\xde"	, "\xfd\x00" },	// Small y with acute
				{ "\xe5\xde"	, "\xff\x00" },	// Small y with dieresis
			};
			#endregion

			string m = "KEY: ";
			foreach(var a in d)
				m += " " + this.s2s(a.Key) + "-" + this.s2s(a.Value);

			Console.WriteLine(m);

			return true;
		}
		#endregion
	}
}
