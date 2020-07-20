using System;

namespace cTime
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("== Start");
			chkTime ct = new chkTime();

			ct.estimate();
			ct.testRound();
			ct.testTF();
			ct.seeRound();
			ct.cal();
			ct.tspan();
			ct.dspyear();
			ct.rere();
			ct.sub();

			ct.getratios();
			ct.dspDate();

			Console.WriteLine("== End");
		}
	}
}
