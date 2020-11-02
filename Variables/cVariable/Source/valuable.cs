using System;

namespace CVariable {

    public class NullAble {

        public class Age {
            public int? Year;
            public int? Month;
            public int? Day;
        }

        public class Profile {
            public string Name;
            public Age Age;
        }

        private void Show(int step, Profile staff) {
            Console.WriteLine($"\n-- Step {step}");

            var year = staff.Age?.Year;
            var month = staff.Age?.Month;
            var day = staff.Age?.Day;

            Console.WriteLine($"name  [{staff.Name}]");

            Console.WriteLine($"year  has value [{(year.HasValue ? "Yes" : "No")}]\t string [{year.ToString()}]");
            Console.WriteLine($"month has value [{(month.HasValue ? "Yes" : "No")}]\t string [{month.ToString()}]");
            Console.WriteLine($"day   has value [{(day.HasValue ? "Yes" : "No")}]\t string [{day.ToString()}]");

            Console.WriteLine($"year greater than 1000\t [{year > 1000}]");
            Console.WriteLine($"month greater than 10\t [{month > 10}]");
        }

        public bool TestValue() {

            #region pretest
            int? n = null;
            Console.WriteLine($"n has value [{n.HasValue}]");
            n = 5;
            Console.WriteLine($"n has value [{n.HasValue}]");
            n = null;
            Console.WriteLine($"n has value [{n.HasValue}]");
            #endregion pretest

            Profile staff = new Profile { Name = "Peter" };
            Show(1, staff);

            staff.Age = new Age { Year = 1996, Month = 3 };
            Show(2, staff);

            return true;
        }

    }

}