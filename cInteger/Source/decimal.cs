using System;

namespace cInt {

    public class DecTest {
        public DecTest() { }

        public void test() {
            decimal vd = 100;
            int vi = 100, vi2= (int)vd;
            Console.WriteLine($"decimal={vd}, integer={vi}, int2={vi2}");

            vi = Convert.ToInt32(vd);
            vd = Convert.ToDecimal(vi2);
            Console.WriteLine($"decimal={vd}, integer={vi}, int2={vi2}");
        }
    }

}
