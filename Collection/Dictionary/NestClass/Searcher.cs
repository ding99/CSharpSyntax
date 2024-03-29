﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NestClass
{
    public class Inner
    {
        public byte Low8 { get; set; }
        public int UCode { get; set; }

        public Inner (byte low8, int ucode)
        {
            this.Low8 = low8;
            this.UCode = ucode;
        }
    }
    public class Outer
    {
        public byte High { get; set; }
        public Inner[] Pair { get; set; }
    }

    public class Searcher
    {
        private readonly Outer[] table;
		private readonly byte[] data;
		private readonly Dictionary<byte, Dictionary<byte, int>> outers;

        public Searcher ()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

			this.outers = new Dictionary<byte, Dictionary<byte, int>> ()
			{
				{ 0xc1, new Dictionary<byte, int>() {
					{ 0x41, 0xc0 },
					{ 0x45, 0xc8 },
					{ 0x49, 0xcc },
					{ 0x4f, 0xd2 },
					{ 0x55, 0xd9 },
					{ 0x61, 0xe0 },
					{ 0x65, 0xe8 },
					{ 0x69, 0xec },
					{ 0x6f, 0xf2 },
					{ 0x75, 0xf9 }
				}},
				{ 0xc2, new Dictionary<byte, int>() {
					{ 0x20, 0x0b4 },
					{ 0x41, 0x0c1 },
					{ 0x43, 0x106 },
					{ 0x45, 0x0c9 },
					{ 0x49, 0x0cd },
					{ 0x4c, 0x139 },
					{ 0x4e, 0x143 },
					{ 0x4f, 0x0d3 },
					{ 0x52, 0x154 },
					{ 0x53, 0x15a },
					{ 0x55, 0x0da },
					{ 0x59, 0x0dd },
					{ 0x5a, 0x179 },
					{ 0x61, 0x0e1 },
					{ 0x63, 0x107 },
					{ 0x65, 0x0e9 },
					{ 0x69, 0x0ed },
					{ 0x6c, 0x13a },
					{ 0x6e, 0x144 },
					{ 0x6f, 0x0f3 },
					{ 0x72, 0x155 },
					{ 0x73, 0x15b },
					{ 0x75, 0x0fa },
					{ 0x79, 0x0fd },
					{ 0x7a, 0x17a }
				}},
				{ 0xc3, new Dictionary<byte, int>() {
					{ 0x41, 0x0c2 },
					{ 0x43, 0x108 },
					{ 0x45, 0x0ca },
					{ 0x47, 0x11c },
					{ 0x48, 0x124 },
					{ 0x49, 0x0ce },
					{ 0x4a, 0x134 },
					{ 0x4f, 0x0d4 },
					{ 0x53, 0x15c },
					{ 0x55, 0x0db },
					{ 0x57, 0x174 },
					{ 0x59, 0x176 },
					{ 0x61, 0x0e2 },
					{ 0x63, 0x109 },
					{ 0x65, 0x0ea },
					{ 0x67, 0x11d },
					{ 0x68, 0x125 },
					{ 0x69, 0x0ee },
					{ 0x6a, 0x135 },
					{ 0x6f, 0x0f4 },
					{ 0x73, 0x15d },
					{ 0x75, 0x0fb },
					{ 0x77, 0x175 },
					{ 0x79, 0x177 }
				}},
				{ 0xc4, new Dictionary<byte, int>() {
					{ 0x41, 0x0c3 },
					{ 0x49, 0x128 },
					{ 0x4e, 0x0d1 },
					{ 0x4f, 0x0d5 },
					{ 0x55, 0x168 },
					{ 0x61, 0x0e3 },
					{ 0x69, 0x129 },
					{ 0x6e, 0x0f1 },
					{ 0x6f, 0x0f5 },
					{ 0x75, 0x169 }
				}},
				{ 0xc5, new Dictionary<byte, int>() {
					{ 0x20, 0x0af },
					{ 0x41, 0x100 },
					{ 0x45, 0x112 },
					{ 0x49, 0x12a },
					{ 0x4f, 0x14c },
					{ 0x55, 0x16a },
					{ 0x61, 0x101 },
					{ 0x65, 0x113 },
					{ 0x69, 0x12b },
					{ 0x6f, 0x14d },
					{ 0x75, 0x16b }
				}},
				{ 0xc6, new Dictionary<byte, int>() {
					{ 0x20, 0x2d8 },
					{ 0x41, 0x102 },
					{ 0x47, 0x11e },
					{ 0x55, 0x16c },
					{ 0x61, 0x103 },
					{ 0x67, 0x11f },
					{ 0x75, 0x16d }
				}},
				{ 0xc7, new Dictionary<byte, int>() {
					{ 0x20, 0x2d9 },
					{ 0x43, 0x10a },
					{ 0x45, 0x116 },
					{ 0x47, 0x120 },
					{ 0x49, 0x130 },
					{ 0x5a, 0x17b },
					{ 0x63, 0x10b },
					{ 0x65, 0x117 },
					{ 0x67, 0x121 },
					{ 0x7a, 0x17c }
				}},
				{ 0xc8, new Dictionary<byte, int>() {
					{ 0x20, 0xa8 },
					{ 0x41, 0xc4 },
					{ 0x45, 0xcb },
					{ 0x49, 0xcf },
					{ 0x4f, 0xd6 },
					{ 0x55, 0xdc },
					{ 0x59, 0x178 },
					{ 0x61, 0xe4 },
					{ 0x65, 0xeb },
					{ 0x69, 0xef },
					{ 0x6f, 0xf6 },
					{ 0x75, 0xfc },
					{ 0x79, 0xff }
				}},
				{ 0xca, new Dictionary<byte, int>() {
					{ 0x20, 0x2da },
					{ 0x41, 0x0c5 },
					{ 0x55, 0x16e },
					{ 0x61, 0x0e5 },
					{ 0x75, 0x16f }
				}},
				{ 0xcb, new Dictionary<byte, int>() {
					{ 0x20, 0x0b8 },
					{ 0x43, 0x0c7 },
					{ 0x47, 0x122 },
					{ 0x4b, 0x136 },
					{ 0x4c, 0x13b },
					{ 0x4e, 0x145 },
					{ 0x52, 0x156 },
					{ 0x53, 0x15e },
					{ 0x54, 0x162 },
					{ 0x63, 0x0e7 },
					{ 0x67, 0x123 },
					{ 0x6b, 0x137 },
					{ 0x6c, 0x13c },
					{ 0x6e, 0x146 },
					{ 0x72, 0x157 },
					{ 0x73, 0x15f },
					{ 0x74, 0x163 }
				}},
				// Latin Extended Additional: Bb Dd h Kk Ll Nn Rr Tt Zz
				{ 0xcc, new Dictionary<byte, int>() {
					{ 0x42, 0x1e06 }, //B
					{ 0x62, 0x1e07 }, //b
					{ 0x44, 0x1e0e }, //D
					{ 0x64, 0x1e0f }, //d
					{ 0x68, 0x1e96 }, //h
					{ 0x4b, 0x1e34 }, //K
					{ 0x6b, 0x1e35 }, //k
					{ 0x4c, 0x1e3a }, //L
					{ 0x6c, 0x1e3b }, //l
					{ 0x4e, 0x1e48 }, //N
					{ 0x6e, 0x1e49 }, //n
					{ 0x52, 0x1e5e }, //R
					{ 0x72, 0x1e5f }, //r
					{ 0x54, 0x1e6e }, //T
					{ 0x74, 0x1e6f }, //t
					{ 0x5a, 0x1e94 }, //Z
					{ 0x7a, 0x1e95 }  //z
				}},
				{ 0xcd, new Dictionary<byte, int>() {
					{ 0x20, 0x2dd },
					{ 0x4f, 0x150 },
					{ 0x55, 0x170 },
					{ 0x6f, 0x151 },
					{ 0x75, 0x171 }
				}},
				{ 0xce, new Dictionary<byte, int>() {
					{ 0x20, 0x2db },
					{ 0x41, 0x104 },
					{ 0x45, 0x118 },
					{ 0x49, 0x12e },
					{ 0x55, 0x172 },
					{ 0x61, 0x105 },
					{ 0x65, 0x119 },
					{ 0x69, 0x12f },
					{ 0x75, 0x173 }
				}},
				{ 0xcf, new Dictionary<byte, int>() {
					{ 0x20, 0x2c7 },
					{ 0x43, 0x10c },
					{ 0x44, 0x10e },
					{ 0x45, 0x11a },
					{ 0x4c, 0x13d },
					{ 0x4e, 0x147 },
					{ 0x52, 0x158 },
					{ 0x53, 0x160 },
					{ 0x54, 0x164 },
					{ 0x5a, 0x17d },
					{ 0x63, 0x10d },
					{ 0x64, 0x10f },
					{ 0x65, 0x11b },
					{ 0x6c, 0x13e },
					{ 0x6e, 0x148 },
					{ 0x72, 0x159 },
					{ 0x73, 0x161 },
					{ 0x74, 0x165 },
					{ 0x7a, 0x17e }
				}}
			};

			this.table = new Outer[]
			{
				new Outer { High = 0xc1, Pair = new Inner[]{
					new Inner (0x41, 0xc0),
					new Inner (0x45, 0xc8),
					new Inner (0x49, 0xcc),
					new Inner (0x4f, 0xd2),
					new Inner (0x55, 0xd9),
					new Inner (0x61, 0xe0),
					new Inner (0x65, 0xe8),
					new Inner (0x69, 0xec),
					new Inner (0x6f, 0xf2),
					new Inner (0x75, 0xf9)
					}},
				new Outer { High = 0xc2, Pair = new Inner[]{
					new Inner (0x20, 0x0b4),
					new Inner (0x41, 0x0c1),
					new Inner (0x43, 0x106),
					new Inner (0x45, 0x0c9),
					new Inner (0x49, 0x0cd),
					new Inner (0x4c, 0x139),
					new Inner (0x4e, 0x143),
					new Inner (0x4f, 0x0d3),
					new Inner (0x52, 0x154),
					new Inner (0x53, 0x15a),
					new Inner (0x55, 0x0da),
					new Inner (0x59, 0x0dd),
					new Inner (0x5a, 0x179),
					new Inner (0x61, 0x0e1),
					new Inner (0x63, 0x107),
					new Inner (0x65, 0x0e9),
					new Inner (0x69, 0x0ed),
					new Inner (0x6c, 0x13a),
					new Inner (0x6e, 0x144),
					new Inner (0x6f, 0x0f3),
					new Inner (0x72, 0x155),
					new Inner (0x73, 0x15b),
					new Inner (0x75, 0x0fa),
					new Inner (0x79, 0x0fd),
					new Inner (0x7a, 0x17a)
				}},
				new Outer { High = 0xc3, Pair = new Inner[]{
					new Inner (0x41, 0x0c2),
					new Inner (0x43, 0x108),
					new Inner (0x45, 0x0ca),
					new Inner (0x47, 0x11c),
					new Inner (0x48, 0x124),
					new Inner (0x49, 0x0ce),
					new Inner (0x4a, 0x134),
					new Inner (0x4f, 0x0d4),
					new Inner (0x53, 0x15c),
					new Inner (0x55, 0x0db),
					new Inner (0x57, 0x174),
					new Inner (0x59, 0x176),
					new Inner (0x61, 0x0e2),
					new Inner (0x63, 0x109),
					new Inner (0x65, 0x0ea),
					new Inner (0x67, 0x11d),
					new Inner (0x68, 0x125),
					new Inner (0x69, 0x0ee),
					new Inner (0x6a, 0x135),
					new Inner (0x6f, 0x0f4),
					new Inner (0x73, 0x15d),
					new Inner (0x75, 0x0fb),
					new Inner (0x77, 0x175),
					new Inner (0x79, 0x177)
				}},
				new Outer { High = 0xc4, Pair = new Inner[]{
					new Inner (0x41, 0x0c3),
					new Inner (0x49, 0x128),
					new Inner (0x4e, 0x0d1),
					new Inner (0x4f, 0x0d5),
					new Inner (0x55, 0x168),
					new Inner (0x61, 0x0e3),
					new Inner (0x69, 0x129),
					new Inner (0x6e, 0x0f1),
					new Inner (0x6f, 0x0f5),
					new Inner (0x75, 0x169 )
				}},
				new Outer { High = 0xc5, Pair = new Inner[]{
					new Inner (0x20, 0x0af),
					new Inner (0x41, 0x100),
					new Inner (0x45, 0x112),
					new Inner (0x49, 0x12a),
					new Inner (0x4f, 0x14c),
					new Inner (0x55, 0x16a),
					new Inner (0x61, 0x101),
					new Inner (0x65, 0x113),
					new Inner (0x69, 0x12b),
					new Inner (0x6f, 0x14d),
					new Inner (0x75, 0x16b)
				}},
				new Outer { High = 0xc6, Pair = new Inner[]{
					new Inner (0x20, 0x2d8),
					new Inner (0x41, 0x102),
					new Inner (0x47, 0x11e),
					new Inner (0x55, 0x16c),
					new Inner (0x61, 0x103),
					new Inner (0x67, 0x11f),
					new Inner (0x75, 0x16d)
				}},
				new Outer { High = 0xc7, Pair = new Inner[]{
					new Inner (0x20, 0x2d9),
					new Inner (0x43, 0x10a),
					new Inner (0x45, 0x116),
					new Inner (0x47, 0x120),
					new Inner (0x49, 0x130),
					new Inner (0x5a, 0x17b),
					new Inner (0x63, 0x10b),
					new Inner (0x65, 0x117),
					new Inner (0x67, 0x121),
					new Inner (0x7a, 0x17c)
					}},
				new Outer { High = 0xc8, Pair = new Inner[]{
					new Inner (0x20, 0xa8),
					new Inner (0x41, 0xc4),
					new Inner (0x45, 0xcb),
					new Inner (0x49, 0xcf),
					new Inner (0x4f, 0xd6),
					new Inner (0x55, 0xdc),
					new Inner (0x59, 0x178),
					new Inner (0x61, 0xe4),
					new Inner (0x65, 0xeb),
					new Inner (0x69, 0xef),
					new Inner (0x6f, 0xf6),
					new Inner (0x75, 0xfc),
					new Inner (0x79, 0xff)
					}},
				new Outer { High = 0xca, Pair = new Inner[]{
					new Inner (0x20, 0x2da),
					new Inner (0x41, 0x0c5),
					new Inner (0x55, 0x16e),
					new Inner (0x61, 0x0e5),
					new Inner (0x75, 0x16f)
					}},
				new Outer { High = 0xcb, Pair = new Inner[]{
					new Inner (0x20, 0x0b8),
					new Inner (0x43, 0x0c7),
					new Inner (0x47, 0x122),
					new Inner (0x4b, 0x136),
					new Inner (0x4c, 0x13b),
					new Inner (0x4e, 0x145),
					new Inner (0x52, 0x156),
					new Inner (0x53, 0x15e),
					new Inner (0x54, 0x162),
					new Inner (0x63, 0x0e7),
					new Inner (0x67, 0x123),
					new Inner (0x6b, 0x137),
					new Inner (0x6c, 0x13c),
					new Inner (0x6e, 0x146),
					new Inner (0x72, 0x157),
					new Inner (0x73, 0x15f),
					new Inner (0x74, 0x163)
					}},
				// Latin Extended Additional: Bb Dd h Kk Ll Nn Rr Tt Zz
				new Outer { High = 0xcc, Pair = new Inner[]{
					new Inner (0x42, 0x1e06), //B
					new Inner (0x62, 0x1e07), //b
					new Inner (0x44, 0x1e0e), //D
					new Inner (0x64, 0x1e0f), //d
					new Inner (0x68, 0x1e96), //h
					new Inner (0x4b, 0x1e34), //K
					new Inner (0x6b, 0x1e35), //k
					new Inner (0x4c, 0x1e3a), //L
					new Inner (0x6c, 0x1e3b), //l
					new Inner (0x4e, 0x1e48), //N
					new Inner (0x6e, 0x1e49), //n
					new Inner (0x52, 0x1e5e), //R
					new Inner (0x72, 0x1e5f), //r
					new Inner (0x54, 0x1e6e), //T
					new Inner (0x74, 0x1e6f), //t
					new Inner (0x5a, 0x1e94), //Z
					new Inner (0x7a, 0x1e95)  //z
					}},
				new Outer { High = 0xcd, Pair = new Inner[]{
					new Inner (0x20, 0x2dd),
					new Inner (0x4f, 0x150),
					new Inner (0x55, 0x170),
					new Inner (0x6f, 0x151),
					new Inner (0x75, 0x171)
					}},
				new Outer { High = 0xce, Pair = new Inner[]{
					new Inner (0x20, 0x2db),
					new Inner (0x41, 0x104),
					new Inner (0x45, 0x118),
					new Inner (0x49, 0x12e),
					new Inner (0x55, 0x172),
					new Inner (0x61, 0x105),
					new Inner (0x65, 0x119),
					new Inner (0x69, 0x12f),
					new Inner (0x75, 0x173)
					}},
				new Outer { High = 0xcf, Pair = new Inner[]{
					new Inner (0x20, 0x2c7),
					new Inner (0x43, 0x10c),
					new Inner (0x44, 0x10e),
					new Inner (0x45, 0x11a),
					new Inner (0x4c, 0x13d),
					new Inner (0x4e, 0x147),
					new Inner (0x52, 0x158),
					new Inner (0x53, 0x160),
					new Inner (0x54, 0x164),
					new Inner (0x5a, 0x17d),
					new Inner (0x63, 0x10d),
					new Inner (0x64, 0x10f),
					new Inner (0x65, 0x11b),
					new Inner (0x6c, 0x13e),
					new Inner (0x6e, 0x148),
					new Inner (0x72, 0x159),
					new Inner (0x73, 0x161),
					new Inner (0x74, 0x165),
					new Inner (0x7a, 0x17e)
				}}
			};

			this.data = new byte[] { 0x30, 0x31, 0xc1, 0x55, 0xc2, 0xc4, 0x69, 0x73, 0x61, 0x73, 0xc4, 0x69 };

            Console.WriteLine ($"Table: {this.table.Length} Outers");
			foreach(var o in this.table)
                Console.WriteLine ($"  High [{o.High:x2}] Pairs [{o.Pair.Length}]");

            Console.WriteLine ($"Dictionary: <outers> has {this.outers.Count} items");
			foreach(var a in this.outers.Keys)
                Console.WriteLine ($"  [{a:x2}] [{this.outers[a].Values.Count}]");

			Console.WriteLine ($"Data : size {this.data.Length}");
			Console.Write (" ");
			for (int i = 0; i < this.data.Length; i++)
				Console.Write ($" {this.data[i]:x2}");
			Console.WriteLine ();
		}

		public void Start ()
        {
            Console.WriteLine ($"-- Start to search for nested classed");
			Console.ForegroundColor = ConsoleColor.Cyan;
			this.Old ();
			this.New ();
			Console.ForegroundColor = ConsoleColor.Green;
			this.Old2 ();
			this.New2 ();
        }

		// Original method. It seems that the decoding logic is not correct
		private string OldDecode(ref int pos)
        {
			if (pos >= this.data.Length)
				return string.Empty;

			foreach (Outer r in this.table)
				if (this.data[pos] == r.High)
				{
					if (++pos < this.data.Length)
						foreach (Inner e in r.Pair)
							if (this.data[pos] == e.Low8)
								return Convert.ToChar (e.UCode).ToString ();

					return $"[{this.data[pos - 1]:x2}{this.data[pos]:x2}]";
				}

			return $"({this.data[pos]:x2})";
		}
		private void Old ()
        {
			StringBuilder b = new StringBuilder ();
			for (int i = 0; i < this.data.Length; i++)
				b.Append (this.OldDecode(ref i));
            Console.WriteLine ($"Old : {b}");
        }

		// Use new method (dictionary) to run the old logic. Should get the same result with Old
		private string NewDecode (ref int pos)
		{
			if (pos >= this.data.Length)
				return string.Empty;

			if (this.outers.TryGetValue (this.data[pos], out Dictionary<byte, int> lows)){
				pos++;
				if(pos < this.data.Length && lows.TryGetValue (this.data[pos], out int va))
					return Convert.ToChar (va).ToString ();
				else return $"[{this.data[pos - 1]:x2}{this.data[pos]:x2}]";
			}

			return $"({this.data[pos]:x2})";
		}
		private void New ()
		{
			StringBuilder b = new StringBuilder ();
			for (int i = 0; i < this.data.Length; i++)
				b.Append (this.NewDecode (ref i));
			Console.WriteLine ($"New : {b}");
		}

		// Correct logic but using the old method
		private string Old2Decode (ref int pos)
		{
			if (pos >= this.data.Length)
				return string.Empty;

			foreach (Outer r in this.table)
				if (this.data[pos] == r.High)
				{
					if (++pos < this.data.Length)
						foreach (Inner e in r.Pair)
							if (this.data[pos] == e.Low8)
								return Convert.ToChar (e.UCode).ToString ();

					pos--;
					return $"[{this.data[pos]:x2}]";
				}

			return $"({this.data[pos]:x2})";
		}
		private void Old2 ()
		{
			StringBuilder b = new StringBuilder ();
			for (int i = 0; i < this.data.Length; i++)
				b.Append (this.Old2Decode (ref i));
			Console.WriteLine ($"Old2: {b}");
		}


		// Both logic and method are new. Should have the same result with Old2
		private string New2Decode (ref int pos)
		{
			if (pos >= this.data.Length)
				return string.Empty;

			if (pos + 1 < this.data.Length &&
				this.outers.TryGetValue (this.data[pos], out Dictionary<byte, int> lows) &&
				lows.TryGetValue (this.data[pos + 1], out int va))
			{
				pos++;
				return Convert.ToChar (va).ToString();
			}

			return $"({this.data[pos]:x2})";
		}
		private void New2 ()
		{
			StringBuilder b = new StringBuilder ();
			for (int i = 0; i < this.data.Length; i++)
				b.Append (this.New2Decode (ref i));
			Console.WriteLine ($"New2: {b}");
		}
	}
}
