using System;

namespace cCharact {

    public class ConstTest{
        public ConstTest() { }

        public void test() {
            Console.WriteLine("Hello\tWorld"); //TAB

            //TODO for \ooo
            Console.WriteLine("A\0725");  //should be "A:5"?

            Console.WriteLine($"Hello\tWorld\x32"); //Hex
        }
    }

}
