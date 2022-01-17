using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestClass
{
    class Program
    {
        static void Main ()
        {
            Console.WriteLine ("== Start");

            Searcher search = new Searcher ();
            search.Start ();

            Console.ResetColor ();
            Console.WriteLine ("== End");
        }
    }
}
