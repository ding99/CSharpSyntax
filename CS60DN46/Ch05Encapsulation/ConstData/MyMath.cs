using System;

namespace ConstData
{
	class MyMath
	{
		public const double PI = 3.14;
		public readonly double PI2;
		public static readonly double PI3;

		public MyMath() { PI2 = 3.1416; }
		
		static MyMath() { PI3 = 3.1415926; }
		public void Test()
		{
			const string fixedin = "Fixed string in a non-static method";
			Console.WriteLine(fixedin);
			Console.WriteLine($"Invoke const data from a non-static mothod: {PI}");
		}
	}
}
