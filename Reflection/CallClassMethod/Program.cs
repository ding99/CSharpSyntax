using System;
using System.Reflection;

namespace CallClassMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("== Call a method from a string");
			new OuterClass().StartOut();
		}

		public class OuterClass
		{
			public void StartOut()
			{
				string nameClass = "InnerClass";
				string nameMethod = "Start";

				Console.WriteLine(nameClass + " / " + nameClass);

				object obj = Activator.CreateInstance(typeof(InnerClass));
				Type t = typeof(InnerClass);
				Console.WriteLine("Class: [" + t + "]");
				if (t != null)
				{
					MethodInfo method = t.GetMethod(nameMethod);
					Console.WriteLine("Method [" + method + "]");
					if (method != null)
						method.Invoke(obj, null);
				}
				else
					Console.WriteLine("not found class");
			}
		}
	}
}
