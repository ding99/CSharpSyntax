using System;

namespace cClass
{
	class Program
	{
		static void Main()
		{

			Console.WriteLine("== Start");
			chkClass c = new chkClass();
			c.className();
			c.classMember();
			c.initClass();

			tCmp t = new tCmp();
			t.toCmp();
			t.declaration();
			
			(new GTree()).multit();

			new OverLaod().Test();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
