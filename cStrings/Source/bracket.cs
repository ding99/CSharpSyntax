using System;

namespace cStrings {
    public class bracket {
        public void test() {
            string s1 = "V1", s2 = "V2";
            string s = String.Format("{{Variables {{{0}}} and {1} are here.}}", s1, s2);
            Console.WriteLine($"s [{s}],  s1 [{s1}] s2 [{s2}]");
        }
    }
}
