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

        #region common
        private void Hello(string person) {
            Console.WriteLine($"Good morning, {person}");
        }
        #endregion

        #region delegate
        private delegate void myDelegator(string s);
        private void ExamineDelegate() {
            Console.WriteLine("-- using delegate");
            myDelegator d = Hello;
            d("Mr. Zhang");
            d.Invoke("Mr. Change(Invoke)");
        }
        #endregion

        #region action
        private void ExamineAction1() {
            Console.WriteLine("-- using Action 1");
            Action<string> a = Hello;
            a("Mr. Wang");
        }

        private void ExamineAction2() {
            Console.WriteLine("-- using Action 2 (Lambda)");
            Action<string> a = (s => Console.WriteLine($"Good night, {s}"));
            a("Mr. Zhao");
            a.Invoke("Mr. Luo(Invoke)");
        }
        #endregion

        #region func
        private int HellowFunc(string person) {
            return person.Length;
        }
        private void ExamineFunc() {
            Console.WriteLine("-- using Func");
            Func<string, int> h = HellowFunc;
            string hello = "Good afternoon, Mr Li";
            Console.WriteLine($"{hello}  ({h(hello)})");
        }
        #endregion
    }

}
