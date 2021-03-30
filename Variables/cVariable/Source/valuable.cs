using System;

namespace CVariable {

    public class NullAble {

        public class Age { public int? Year; public int? Month; public int? Day; }
        public class Profile { public string Name; public Age Age; }

        public NullAble() {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--> Examine NullAble");
        }

        private void Show(int step, Profile staff) {
            Console.WriteLine($"-- Step {step}");
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

        public void TestValue() {
			Console.WriteLine("-- nullable int");
            #region pretest
            int? n = null; Console.WriteLine($"n(null) has value [{n.HasValue}]");
            n = 5; Console.WriteLine($"n( 5 )  has value [{n.HasValue}]");
            n = null; Console.WriteLine($"n(null) has value [{n.HasValue}]");
            #endregion pretest

            Console.WriteLine("-- nullable class members");
            Profile staff = new Profile { Name = "Peter" }; Show(1, staff);
            staff.Age = new Age { Year = 1996, Month = 3 }; Show(2, staff);
        }

        public void ExceptionMessage() {
			Console.WriteLine("-- Exception Message");
            try {
                int? n1 = null;
                int n2 = (int)n1;
            }
            catch(Exception e) {
                Console.WriteLine($"Exception: {e.Message}");
			}
		}

    }

}