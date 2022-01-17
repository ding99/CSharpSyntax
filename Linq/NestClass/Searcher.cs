using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Searcher ()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

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
				new Outer { High = 0xc6, Pair =  new Inner[]{
					new Inner (0x20, 0x2d8),
					new Inner (0x41, 0x102),
					new Inner (0x47, 0x11e),
					new Inner (0x55, 0x16c),
					new Inner (0x61, 0x103),
					new Inner (0x67, 0x11f),
					new Inner (0x75, 0x16d)
				}}
			};

			this.data = new byte[] { 0x30, 0x31, 0xc1, 0x55, 0xc2, 0xc4, 0x69, 0x73, 0x61, 0x73, 0xc4, 0x69 };

            Console.WriteLine ($"Table: {this.table.Count()} Outers");
			foreach(var o in this.table)
                Console.WriteLine ($"  High [{o.High:x2}] Pairs [{o.Pair.Count()}]");

			Console.WriteLine ($"Data : {this.data.Count ()}");
			Console.Write (" ");
			for(int i = 0; i < this.data.Length; i++)
                Console.Write ($" {this.data[i]:x2}");
            Console.WriteLine ();
		}

		public void Start ()
        {
            Console.WriteLine ($"-- Start to search for nested classed");
			this.Old ();
        }

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
            Console.WriteLine (b.ToString());
        }
    }
}
