using System;

namespace cVariable {

    public class Examine{

        public void Interpolation() {
			Console.WriteLine("-> Examing string interpolation");
            int a = 123;
            Console.WriteLine($"value[{a}]");
        }

        public void ExamineStruct() {
			Console.WriteLine("-> Examime how to invoke a struct");
            Student Tom;
            Tom.Name = "Tom";
            Tom.Age = 20;
            Tom.Display();
		}
    }

    struct Student {
        public string Name;
        public int Age;

        public void Display() {
			Console.WriteLine($"Name [{Name}], Age [{Age}]");
		}
	}

}
