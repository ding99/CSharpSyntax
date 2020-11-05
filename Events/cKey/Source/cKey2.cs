using System;

namespace CEvent {

    public class EventTest2 {
        private void checkStat(object obj, StateArgs args) {
            Console.WriteLine("Status " + args.status + ", " + args.message);
        }

        public void test() {
            new Worker2().Start("KeyTest2", new EventHandler<StateArgs>(checkStat));
        }
    }
}
