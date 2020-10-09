using System;
using System.Reflection;

namespace AttributeAppl {
	class Program {
		static void Main() {
			Console.WriteLine("== How to use custom attributes");

			MemberInfo info = typeof(MyClass);
			object[] attributes = info.GetCustomAttributes(true);
			for (int i = 0; i < attributes.Length; i++)
				Console.WriteLine($" - {attributes[i]}");
		}
	}
}
