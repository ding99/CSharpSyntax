using System;

namespace CustomEnumeratorWithYield
{
	class Radio
	{
		public void TrunOn(bool on)
		{
			if(on) Console.WriteLine("Jamming...");
			else Console.WriteLine("Quiet time...");
		}
	}
}
