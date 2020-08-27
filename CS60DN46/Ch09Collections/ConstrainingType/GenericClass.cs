using System;

namespace ConstrainingType
{
	public class GenericClass<T> where T : new() 
	{
		public T X { get; set; }

		public void Swap(ref T a, ref T b)
		{
			Console.WriteLine($"You sent the Swap() method a {typeof(T)}");
			T temp = a;
			a = b;
			b = temp;
		}

		public void DisplayBaseClass()
		{
			Console.WriteLine($"Base class of {typeof(T)} is: {typeof(T).BaseType}");
		}
	}
}
