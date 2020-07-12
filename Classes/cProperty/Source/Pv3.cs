using System;

namespace cProperty {
    public class Student3 {

        public string Code { get; set; } = "N.A";
        public string Name { get; set; } = "N.A";
        public int Age { get; set; } = 0;

        public override string ToString() {
            return $"Code:{Code},Name:{Name},Age:{Age}";
        }
    }

    public class PV3 {
        public PV3() { }

        public void test() {
            Student3 s = new Student3();
            Console.WriteLine($"Student Info={s}");

            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            Console.WriteLine($"Student Info={s}");

            s.Age++;
            Console.WriteLine($"Student Info={s}");
        }
    }

}
