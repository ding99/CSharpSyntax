using System;

namespace CDelegate {


    public class Delegator {
        public Delegator() { }

        #region delegate
        public delegate void myDelegator(string s);
        public void Hello(string person) {
            Console.WriteLine("Good morning, " + person);
        }
        public void dele() {
            Console.WriteLine("-- using delegate");
            //myDelegator d = new myDelegator(Hello);
            myDelegator d = Hello;
            d("Mr Zhang");
        }
        #endregion

        #region action
        public void actn() {
            Console.WriteLine("-- using Action 1");
            Action<string> a = Hello;
            a("Mr Wang");
        }

        public void act2() {
            Console.WriteLine("-- using Action 2");
            Action<string> a = (s => Console.WriteLine("Good night, " + s));
            a("Mr. Zhao");
        }
        #endregion

        #region func
        public int Hellowf(string person) {
            return person.Length;
        }
        public void func() {
            Console.WriteLine("-- using Func");
            Func<string, int> h = Hellowf;
            string hello = "Good afternoon, Mr Li";
            Console.WriteLine(hello + " (" + h(hello) + ")");
        }
        #endregion
    }

}
