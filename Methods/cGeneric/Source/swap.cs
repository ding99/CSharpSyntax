using System;

namespace cGeneric {
    public class CheckSwap {

        static void Swap<T>(ref T lhs, ref T rhs) {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public void testswap() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=> Practice Generic Method");
 
            int a = 10, b = 20;
            char c = 'I', d = 'V';

            Console.WriteLine($"Int  values before calling swap: a = {a}, b = {b}");
            Console.WriteLine($"Char values before calling swap: c = {c}, d = {d}");

            Swap(ref a, ref b);
            Swap(ref c, ref d);

            Console.WriteLine($"Int  values after calling swap: a = {a}, b = {b}");
            Console.WriteLine($"Char values after calling swap: c = {c}, d = {d}");
        }
    }
}
