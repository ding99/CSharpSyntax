using System;
using System.Text.RegularExpressions;

namespace CRegex {
    class genRegex {

        public genRegex() { }

        public void cmp() {
            Console.WriteLine("=== Replacement Comparison ===");
            string a = "123456789", b = a, key = "456", target = "ABC";
            string c = a.Replace(key, target);
            string d = new Regex(key).Replace(b, target);

            Console.WriteLine($"General source [{a}] destination [{c}]");
            Console.WriteLine($"Regex   source [{b}] destination [{d}]");
            Console.WriteLine($"Same [{c == d}]");
        }

        private void oneAlign(string s) {
            string key = @"{\\an[\d]}";
            //key = "called";
            Match m = new Regex(key).Match(s);
            Console.WriteLine($"key [{key}] string [{s}]\t match ({m.Success}) value [{m.Value}] [{m.Index} / {m.Length}]");
        }

        public void align() {
            oneAlign(@"{\an2}It's called collections Billy.");
            oneAlign(@"It's called collections Billy.");
            oneAlign(@"{a\an2}It's called collections Billy.");
            oneAlign(@"{\an22}It's called collections Billy.");
            oneAlign(@"{\an}It's called collections Billy.");
            oneAlign(@"{\an8}It's called collections Billy.");
        }
    }
}
