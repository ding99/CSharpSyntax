using System;

namespace cClass
{
	class Program
	{
		static void Main(string[] args)
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
			
			Console.WriteLine("== End");
		}
	}
}
