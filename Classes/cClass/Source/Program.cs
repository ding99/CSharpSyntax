using System;

namespace CClass
{
	class Program
	{
		static void Main()
		{

			Console.WriteLine("== Start");
			ChkClass c = new ChkClass();
			c.className();
			c.classMember();
			c.initClass();

			TCmp t = new TCmp();
			t.toCmp();
			t.declaration();
			
			(new GTree()).multit();

			new OverLaod().Test();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
