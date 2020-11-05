using System;

namespace CSerialize
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("== start");
			bool ret = true;

			SDS sds = new SDS();
			if (ret) ret = sds.binaryT();
			if(ret) ret = sds.stringT();

			Console.WriteLine("== end (" + (ret ? "succeed" : "fail") + "ed)");
			Console.ReadKey();
		}
	}
}
