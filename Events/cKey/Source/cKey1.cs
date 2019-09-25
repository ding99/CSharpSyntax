using System;
using WorkLib;

namespace CEvent {

    public class EventTest1 {

        public EventTest1() { }

        private void checkStat(object obj, StatArgs args) {
            Console.WriteLine("Status " + args.stat + " / " +
                args.pgs + " / " + args.message);
        }

        public void test() {
            Console.WriteLine("Press key please! S for start");

            ConsoleKeyInfo kinfo;
            do {
                kinfo = Console.ReadKey();
                Console.WriteLine(kinfo.Key + " was pressed");
            }
            while(kinfo.Key != ConsoleKey.S);

            new Worker().Start("SUB", new EventHandler<StatArgs>(checkStat));

        }
    }
}
