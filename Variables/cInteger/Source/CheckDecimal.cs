using System;

namespace cInt {

    public class CheckDecimal {
        public CheckDecimal() { }

        public void Start() {
			Console.WriteLine("-- Decimal");
            decimal vd = 100;
            int vi = 100, vi2= (int)vd;
            double db = (double)vd;
            Console.WriteLine($"decimal={vd}({vd.GetType()}), integer={vi}({vi.GetType()}), int2={vi2}({vi2.GetType()}), double={db}({db.GetType()})");

            vi = Convert.ToInt32(vd);
            vd = Convert.ToDecimal(vi2);
            Console.WriteLine($"decimal={vd}({vd.GetType()}), integer={vi}({vi.GetType()}), int2={vi2}({vi2.GetType()})");
        }
    }

}
