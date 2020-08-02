using System;
using System.Numerics;

namespace Numerics
{
	class Program
	{
		static void Main(string[] args)
		{
			UseBigInteger();
		}

		static void UseBigInteger()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine("=> Use BigInteger:");
			BigInteger big = BigInteger.Parse("9999999999999999999999999999999999999999999999");
			Console.WriteLine("Value of big is {0}", big);
			Console.WriteLine("Is big an even value?: {0}", big.IsEven);
			Console.WriteLine("Is big a power of two: {0}", big.IsPowerOfTwo);

			BigInteger reallyBig = BigInteger.Multiply(big, BigInteger.Parse("8888888888888888888888888888888888888888888"));
			Console.WriteLine("Value of rBig is {0}", reallyBig);
			Console.WriteLine();

			Console.ResetColor();
		}
	}
}
