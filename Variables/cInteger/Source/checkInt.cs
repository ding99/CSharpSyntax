using System;

namespace cInt.Source
{
	public class CheckInt
	{
        private void sone(int n)
        {
            Console.WriteLine(n + "  " + ((n + 3) >> 2 << 2));
        }
        public void shift()
        {
            sone(4);
            sone(5);
            sone(6);
            sone(7);
            sone(8);
        }

        public void max()
		{
            Console.WriteLine("Max int is [" + Int32.MaxValue + "]");
		}
    }
}
