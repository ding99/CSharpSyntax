using System;

namespace CustomGenericMethods
{
	class MyGenericMethods
	{
		public void Swap<T>(ref T a, ref T b)
		{
			Console.WriteLine($"You sent the Swap() method a {typeof(T)}");
			T temp = a;
			a = b;
			b = temp;
		}

		public void DisplayBaseClass<T>()
		{
			Console.WriteLine($"Base class of {typeof(T)} is: {typeof(T).BaseType}");
		}
	}
}
