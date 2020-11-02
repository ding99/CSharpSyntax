using System;
using System.Collections.Generic;

namespace CList {
    public class CheckJoin {
        List<string> list;

        public CheckJoin() {
            list = new List<string>();
            list.Add("Term01");
            list.Add("Term02");
            list.Add("Term03");
        }

        private void dsp(List<string> a) {
            Console.WriteLine("------");
            foreach(string s in a)
                Console.Write(" " + s);
            Console.WriteLine();
        }
        public void join() {

            List<string> l1 = new List<string>{
                "AAAAAA",
                "BBBBBB",
                "CCCCCC",
                "DDDDDD",
            };

            List<string> l2 = new List<string>{
                "aaaaaa",
                "bbbbbb"
            };

            dsp(l1);
            dsp(l2);
            
            l1.AddRange(l2);
            dsp(l1);

            l1.AddRange(l2);
            dsp(l1);

            try {
                l1.AddRange(new List<string>());
                dsp(l1);
            }
            catch(Exception e) {
                Console.WriteLine($"exception for adding a empty list <{e.Message}>");
            }
        }
    }
}
