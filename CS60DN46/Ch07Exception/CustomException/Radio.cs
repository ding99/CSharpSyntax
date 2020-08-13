using System;

namespace CustomException
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
