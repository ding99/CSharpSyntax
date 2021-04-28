using System;

namespace CDelegate {
    public class ExamineInvoke {

        protected delegate string MyDelegate(string msg);

        public ExamineInvoke() {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-- Hello Invoke!");
        }

        public void Start() {
            var start = new MyDelegate(Love);
			Console.WriteLine(start("<Testing var>"));
			Console.WriteLine(start.Invoke("[Testing var with Invoke]"));

            MyDelegate oass = Love;
			Console.WriteLine(oass("<Testing pass>"));
			Console.WriteLine(oass.Invoke("[Testing pass with Invoke]"));

            MyDelegate newPass = new MyDelegate(Love);
			Console.WriteLine(newPass("<Testing new>"));
			Console.WriteLine(newPass.Invoke("[Testing new with Invoke]"));
        }

        private string Love(string msg) {
            Console.WriteLine($"DELEGATE: {msg}");
            return $"{msg} DELEGATING Started";
        }

    }
}
