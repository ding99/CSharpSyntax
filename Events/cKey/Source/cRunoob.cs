using System;
using System.IO;

namespace CEvent {

    #region example 1
    #region  publisher
    public class EventTest {

        private int value;

        public EventTest() { SetValue(5); }

        #region event
        public delegate void NumManipulationHandler(int n);

        public event NumManipulationHandler ChangeNum;

        protected virtual void OnNumChanged() {
            if(ChangeNum != null) {
                ChangeNum(value);  //event was triggered
            } else {
                Console.WriteLine("event not fire");
                Console.ReadKey(); //return for continue
            }
        }

        #endregion

        public void SetValue(int n) {
            if(value != n) {
                value = n;
                OnNumChanged();
            }
        }
    }
    #endregion publisher

    #region subscriber
    public class SubscribEvent {
        public void printf(int n) {
            Console.WriteLine($"event fire ({n})");
            Console.ReadKey();
        }
    }
    #endregion subscriber
    #endregion example 1

    #region example 2
    #region publisher
    class Boiler {
        private int temp;
        private int pressure;
        public Boiler(int t, int p) { temp = t; pressure = p; }

        public int getTemp() { return temp; }
        public int getPressure() { return pressure; }
    }

    class DelegateBoilerEvent {
        public delegate void BoilerLogHander(string status);

        public event BoilerLogHander BoilerEventLog;

        public void LogProcess() {
            string remarks = "O.K";
            Boiler b = new Boiler(100, 12);
            int t = b.getTemp();
            int p = b.getPressure();

            if(t > 150 || t < 80 || p < 12 || p > 15)
                remarks = "Need maintenance";

            OnBoilerEventLog($"Logging Info: Temparature {t}, Pressure: {p}");
            OnBoilerEventLog($"Message: {remarks}");
        }

        protected void OnBoilerEventLog(string message) {
            //BoilerEventLog?.Invoke(message); //may replace the 2 lines below
            if(BoilerEventLog != null)
                BoilerEventLog(message);
        }
    }
    #endregion publisher

    #region subscriber (partial?)
    class BoilerInfoLogger {
        FileStream fs;
        StreamWriter sw;

        public BoilerInfoLogger(string filename) {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }
        public void LoggerFile(string info) { sw.WriteLine(info); }
        public void LoggerConsole(string info) { Console.WriteLine(info); }

        public void Close() { sw.Close(); fs.Close(); }
    }
    #endregion subscriber
    #endregion example 2

    public class ByRunoob {

        public void test1() {
            SubscribEvent v = new SubscribEvent();

            EventTest e = new EventTest();
            e.ChangeNum += new EventTest.NumManipulationHandler(v.printf);
            e.SetValue(7);
            e.SetValue(11);
        }

        public void test2() {
            BoilerInfoLogger filelog = new BoilerInfoLogger("d:\\workFolder\\Events\\boiler.log");

            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHander(filelog.LoggerConsole);
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHander(filelog.LoggerFile);
            boilerEvent.LogProcess();

            filelog.Close();
        }
    }
}
