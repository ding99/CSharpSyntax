using System;
using System.Collections;

namespace cDelegate {

    delegate int NumberChanger(int n);

    public class MultiDelegate {

        static int num = 10;
        public MultiDelegate() { }

        public static int AddNum(int p) { num += p; return num; }
        public static int MultiNum(int q) { num *= q; return num; }
        public static int GetNum() { return num; }

        public void TestSingle() {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);

            nc1(25);
            Console.WriteLine($"Value of Num: [{GetNum()}]");

            nc2(5);
            Console.WriteLine($"Value of Num: [{GetNum()}]");
        }

        public void TestMulti() {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);

            NumberChanger nc = nc1;
            nc += nc2;
            nc(5);
            Console.WriteLine($"Value of Num: [{GetNum()}]");
        }

    }

}
