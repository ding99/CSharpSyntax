using System;
using System.Text.RegularExpressions;

namespace CRegex
{
    class Reverse
    {
        public Reverse ()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private void One(string s)
        {
            string key = "0*$";
            Match m = new Regex(key).Match (s);
            Console.WriteLine ($"key [{key}] string[{s}] match ({m.Success}) value [{m.Value}] [{m.Index}]");
        }

        public void Start ()
        {
            this.One ("11223344500000");
            this.One ("00011100000");
            this.One ("aabbcc00000");
            this.One ("1234560");
        }
    }
}
