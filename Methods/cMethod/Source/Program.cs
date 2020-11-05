namespace CMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("== Start");

			(new CPrm()).checkPrm();

			CMemo cm = new CMemo();
			cm.checkmemos();

			Switcher sw = new Switcher();
			sw.ExamingSwitch();

			System.Console.WriteLine("== End");
		}
	}
}
