using System;

namespace CDelegate {


    public class Delegator {
        public Delegator() { Console.ForegroundColor = ConsoleColor.Yellow; }

        public void Start() {
            ExamineDelegate();
            ExamineAction1();
            ExamineAction2();
            ExamineFunc();
		}

        #region delegate
        public delegate void myDelegator(string s);
        private void Hello(string person) {
            Console.WriteLine("Good morning, " + person);
        }
        private void ExamineDelegate() {
            Console.WriteLine("-- using delegate");
            myDelegator d = Hello;
            d("Mr Zhang");
        }
        #endregion

        #region action
        private void ExamineAction1() {
            Console.WriteLine("-- using Action 1");
            Action<string> a = Hello;
            a("Mr Wang");
        }

        public void ExamineAction2() {
            Console.WriteLine("-- using Action 2");
            Action<string> a = (s => Console.WriteLine("Good night, " + s));
            a("Mr. Zhao");
        }
        #endregion

        #region func
        public int Hellowf(string person) {
            return person.Length;
        }
        public void ExamineFunc() {
            Console.WriteLine("-- using Func");
            Func<string, int> h = Hellowf;
            string hello = "Good afternoon, Mr Li";
            Console.WriteLine(hello + " (" + h(hello) + ")");
        }
        #endregion
    }

}
