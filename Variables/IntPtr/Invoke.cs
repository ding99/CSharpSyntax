using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace IntPtr {
	public class Invoke {
		public Invoke() { Console.ForegroundColor = ConsoleColor.Yellow; }

		public void Start() {
			Console.WriteLine("invoke");

			int nValue1 = 10, nValue2 = 20;

			//AllocHGlobal: allocate unmamaged memory
			System.IntPtr ptr1 = Marshal.AllocHGlobal(sizeof(int) * 2);
			System.IntPtr ptr2 = Marshal.AllocHGlobal(sizeof(int));

			//write unmanaged memory
			Marshal.WriteInt32(ptr1, 0, nValue1);
			Marshal.WriteInt32(ptr1, sizeof(int), nValue2);
			Marshal.WriteInt32(ptr2, nValue1);

			//read unmanged memory with a offset
			int read1_1 = Marshal.ReadInt32(ptr1, 0);
			int read1_2 = Marshal.ReadInt32(ptr1, 4);
			int read2 = Marshal.ReadInt32(ptr2, 0);

			Console.WriteLine($"Original Values: [{nValue1}], [{nValue2}]");
			Console.WriteLine($"Read Values from ptr1: [{read1_1}], [{read1_2}]");
			Console.WriteLine($"Read Values from ptr2: [{read2}]");

			//release unmanaged momory
			Marshal.FreeHGlobal(ptr1);
			Marshal.FreeHGlobal(ptr2);

			Console.WriteLine("finish");
		}
	}
}
