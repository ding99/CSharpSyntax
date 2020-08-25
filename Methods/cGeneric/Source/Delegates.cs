using System;

namespace cGeneric {

    delegate T NumberChanger<T>(T n);

    public class CheckDele{

        static int num = 10;
        public static int AddNum(int p) {
            num += p;
            return num;
        }

        public static int MultNum(int q) {
            num *= q;
            return num;
        }

        public static int getNum() {
            return num;
        }


        public void testdele() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=> Practice Generic Delegate");

            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            nc1(25);
            Console.WriteLine($"Value of Num: {getNum()}");
            nc2(5);
            Console.WriteLine($"Value of Num: {getNum()}");
        }
    }
}
