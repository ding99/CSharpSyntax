using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cList.Source
{
	public class cLoop
	{
		public void LoopStart()
		{
			Console.WriteLine("-- Loop");
			for (int i = 2; i < 2; i++)
				Console.WriteLine("  " + i);
			Console.WriteLine("-- End");
		}
	}
}
