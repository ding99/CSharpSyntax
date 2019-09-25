using System;

namespace cInt {

    public class Test{
        public Test() { }

        private void sone(int n) {
            Console.WriteLine(n + "  " + ((n + 3) >> 2 << 2));
        }
        public void shift() {
            sone(4);
            sone(5);
            sone(6);
            sone(7);
            sone(8);
        }
    }
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("== Start");

            //Test test = new Test();
            //test.shift();

            new DecTest().test();

            Console.WriteLine("== End");
        }
    }
}
