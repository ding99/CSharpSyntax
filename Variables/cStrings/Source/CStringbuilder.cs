using System;
using System.Text;

namespace CStrings {
    public class CStringbuilder {
        public void cap() {

            Console.WriteLine("--- string builder with default capacity");
            StringBuilder b1 = new StringBuilder();
            Console.WriteLine($"capacity [{b1.Capacity}]  string length [{b1.ToString().Length}] / [{b1.Length}]");
            b1.Append("Add1");
            Console.WriteLine($"capacity [{b1.Capacity}]  string length [{b1.ToString().Length}] / [{b1.Length}]");
            b1.Append("Additional0000000002");
            Console.WriteLine($"capacity [{b1.Capacity}]  string length [{b1.ToString().Length}] / [{b1.Length}]");
            b1.Append("Additional0000000003");
            Console.WriteLine($"capacity [{b1.Capacity}]  string length [{b1.ToString().Length}] / [{b1.Length}]");
            b1.Append("");
            Console.WriteLine($"capacity [{b1.Capacity}]  string length [{b1.ToString().Length}] / [{b1.Length}]");
            string s1 = b1.ToString();
            Console.WriteLine($"string 1 [{s1} ({s1.Length})]");

            Console.WriteLine();
            int size = 20;
            Console.WriteLine($"--- string builder with specified capacity {size}");
            StringBuilder b2 = new StringBuilder(size);
            Console.WriteLine($"capacity [{b2.Capacity}]  string length [{b2.ToString().Length}] / [{b2.Length}]");
            b2.Append("Add1");
            Console.WriteLine($"capacity [{b2.Capacity}]  string length [{b2.ToString().Length}] / [{b2.Length}]");
            b2.Append("Additional0000000002");
            Console.WriteLine($"capacity [{b2.Capacity}]  string length [{b2.ToString().Length}] / [{b2.Length}]");
            b2.Append("Additional0000000003");
            Console.WriteLine($"capacity [{b2.Capacity}]  string length [{b2.ToString().Length}] / [{b2.Length}]");
            b2.Append(string.Empty);
            Console.WriteLine($"capacity [{b2.Capacity}]  string length [{b2.ToString().Length}] / [{b2.Length}]");
            string s2 = b2.ToString();
            Console.WriteLine($"string 2 [{s2} ({s2.Length})]");

            Console.WriteLine();
            Console.WriteLine($"same strings? [{s1 == s2}] / [{s1.Equals(s2)}]");
        }

        private void append(StringBuilder b, string value){
            b.Append(" ").Append(value);
        }
        private void insert(StringBuilder b, string value) {
            b.Insert(0, value);
        }
        public void prm() {
            StringBuilder b = new StringBuilder();
            b.Append("Base01");
            append(b, "Append01");
            insert(b, "Insert01 ");
            append(b, "Append02");
            string s = b.ToString();
            Console.WriteLine($"result [{s}]");
        }

        public void jon() {
            StringBuilder b1 = new StringBuilder();
            b1.Append("Base01");
            b1.Append(" Append01");

            StringBuilder b2 = new StringBuilder();
            b2.Append("Base02");
            b2.Append(" Append02");

            Console.WriteLine($"b1 result [{b1.ToString()}]");
            Console.WriteLine($"b2 result [{b2.ToString()}]");

            b1.Append(b2);
            Console.WriteLine($"b1 result [{b1.ToString()}]");
        }
    }
}
