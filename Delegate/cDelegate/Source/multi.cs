using System;
using System.Collections;

namespace CDelegate {

    delegate int NumberChanger(int n);

    public class MultiDelegate {

        static int num = 10;
        public MultiDelegate() {
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"actor: the initial num is [{num}]");
        }

        private static int AddNum(int p) { num += p; return num; }
        private static int MultiNum(int q) { num *= q; return num; }
        private static int GetNum() { return num; }

        private void TestSingle() {
			Console.WriteLine($"-- Test Single to ADD 25 then Multi 5. Original num: [{GetNum()}]");

            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);

            nc1(25);
            Console.WriteLine($"Value of Num: [{GetNum()}]");

            nc2(5);
            Console.WriteLine($"Value of Num: [{GetNum()}]");
        }

        private void TestMulti() {
            Console.WriteLine($"-- Test Multi to ADD-Multi 5. Original num: [{GetNum()}]");

            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);

            NumberChanger nc = nc1;
            nc += nc2;
            nc(5);
            Console.WriteLine($"Value of Num: [{GetNum()}]");
        }

        public void Start() {
            TestSingle();
            TestMulti();
		}

    }

}
