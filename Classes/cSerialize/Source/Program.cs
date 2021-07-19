using System;

namespace CSerialize
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("== start");

			new Mapping().Start();

			bool ret = true;

			SDS sds = new SDS();
			ret = sds.binaryT();
			if(ret) ret = sds.stringT();

			Console.WriteLine("== end (" + (ret ? "succeed" : "fail") + "ed)");

			Console.ResetColor();
		}
	}
}
