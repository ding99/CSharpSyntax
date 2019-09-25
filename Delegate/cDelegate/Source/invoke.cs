using System;

namespace cDelegate {
    public class Invoke {

        protected delegate string MyDelegate(string msg);

        public void start() {
            Console.WriteLine("Hello Dele!");
            var start = new MyDelegate(Love);
            start("Testing started");

            start.Invoke("Invoke Testing started");

            MyDelegate stt = Love;
            stt("stt testing ...");
            stt.Invoke("Invoke stt testing ...");

            MyDelegate stt1 = new MyDelegate(Love);
            stt1("stt1 testing ...");
            stt1.Invoke("Invoke stt1 testing ...");
        }

        private string Love(string msg) {
            Console.WriteLine("DELEGATE: " + msg);
            return msg + " DELEGATING Started";
        }

    }
}
