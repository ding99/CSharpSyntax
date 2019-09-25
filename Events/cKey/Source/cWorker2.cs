using System;

namespace CEvent {

    public enum Status {
        Waiting,
        Running,
        Finished
    }

    public class StateArgs : EventArgs {
        public Status status;
        public string message;

        public StateArgs() {
            status = Status.Waiting;
            message = String.Empty;
        }
    }

    public class Worker2 {

        private EventHandler<StateArgs> _handler;
        private StateArgs _arguments;
        private string _base;

        public Worker2() {
            _handler = null;
            _arguments = new StateArgs();
            _base = String.Empty;
        }

        private void update(Status stt, string msg) {
            _arguments.status = stt;
            _arguments.message = _base + (!string.IsNullOrWhiteSpace(msg) ? " " + msg : "");

            if(_handler != null)
                _handler(this, _arguments);
        }

        public void Start(string name, EventHandler<StateArgs> handler) {
            _handler = handler;
            _base = name;

            update(Status.Waiting, "Press key please! S for stop");

            ConsoleKeyInfo keyinfo;
            do {
                keyinfo = Console.ReadKey(true);
                update(Status.Running, keyinfo.Key.ToString().ToLower() + "/"
                    + keyinfo.Key + " was pressed");
            }
            while(keyinfo.Key != ConsoleKey.S);

            update(Status.Finished, "Success");
        }

    }
}
