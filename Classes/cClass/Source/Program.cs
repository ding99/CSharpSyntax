using cClass;
using System;
using System.Reflection;

namespace CClass
{
	class Program
	{
		static void Main()
		{

			Console.WriteLine("== Start");
			//ChkClass c = new ChkClass();
			//c.className();
			//c.classMember();
			//c.initClass();

			TCmp t = new TCmp();
			t.toCmp();
			t.declaration();

			//(new GTree()).multit();

			new OverLoad().Test();

			//Console.ResetColor();

			#region assembly
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Assembly");
			Assembly sampleAssembly;
			var class1 = new Class1();
			sampleAssembly = Assembly.GetAssembly(class1.GetType());
			var types = sampleAssembly.GetTypes();
			foreach(Type typ in types) {
				Console.WriteLine(typ);
			}
			#endregion

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
