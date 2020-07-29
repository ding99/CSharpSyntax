using System;

namespace Temp01
{
	public class Entrance
	{
		public bool Start()
		{
			Console.WriteLine("== Start Sub");

			Verify01 v01 = new Verify01();
			string pattern = "010", source = "amazing";
			int number = v01.StringPatternMatching(pattern, source);

			Console.WriteLine("-- result");
			Console.WriteLine("Pattern: " + pattern);
			Console.WriteLine("Source : " + source);
			Console.WriteLine("number : " + number);

			return true;
		}

    }
}
