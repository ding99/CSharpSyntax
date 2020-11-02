using System;

namespace CStrings {
    public class CheckTrim {

        private void ctrim(string s) {
            Console.Write($"Orig [{s}]\t Trim:\t\t");
            try {
                s = s.Trim();
                Console.Write($"No exception <{s}>");
            } catch(Exception e) {
                Console.Write($"Exception <{e.Message}>");
            }
            Console.WriteLine();
        }
        private void cstart(string s) {
            Console.Write($"Orig [{s}]\t StartWith:\t");
            try {
                Console.Write($"Startwith space <{s.StartsWith(" ")}>. ");
                Console.Write($"No exception <{s}>");
            } catch(Exception e) {
                Console.Write($"Exception <{e.Message}>");
            }
            Console.WriteLine();
        }
        private void clow(string s) {
            Console.Write($"Orig [{s}]\t ToLower:\t");
            try {
                s = s.ToLower();
                Console.Write($"No exception <{s}>");
            } catch(Exception e) {
                Console.Write($"Exception <{e.Message}>");
            }
            Console.WriteLine();
        }

        private void cpair(string s) {
            ctrim(s);
            cstart(s);
            clow(s);
            Console.WriteLine("------");
        }
        public void checks() {
            cpair("");
            cpair(" ");
            cpair("a");
            cpair("A");
            cpair(" a");
            cpair("aAa");
            cpair(string.Empty);
        }
    }
}
