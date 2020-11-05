using System;

namespace CProperty {
    public class Student2 {
        private string code;
        private string name;
        private int age;

        public string Code {
            get { return code; }
            set { code = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }

        public override string ToString() {
            return $"Code = {Code}, Name = {Name}, Age = {Age}";
        }
    }

    public class PV2 {
        public PV2() { }

        public void test() {
            Student2 s = new Student2();
            Console.WriteLine("Student Info: {0}", s);

            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            Console.WriteLine("Student Info: {0}", s);

            s.Age++;
            Console.WriteLine("Student Info: {0}", s);
        }
    }

}
