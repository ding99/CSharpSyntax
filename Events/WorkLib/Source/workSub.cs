using System;

namespace WorkLib {

	public enum Status {
		None,
		Waiting,
		Running,
		Success,
		Failuer
	}

	public class StatArgs : EventArgs {
		public Status stat;
		public int pgs;
		public string message;

		public StatArgs() {
			this.stat = Status.None;
			this.pgs = 0;
			this.message = String.Empty;
		}
	}

	public class Worker {

		private EventHandler<StatArgs> evt;
		private StatArgs args;
		private string bas;

		public Worker() {
			this.evt = null;
			this.args = new StatArgs();
			this.bas = String.Empty;
		}

		private void update(int prgs, Status stt = Status.None, string msg = "") {
			this.args.pgs = prgs;
			this.args.stat = stt;
			this.args.message = this.bas + (String.IsNullOrWhiteSpace(msg)? "" : " "  + msg);

			if(this.evt != null)
				this.evt(this, this.args);
		}

		public bool Start(string logo, EventHandler<StatArgs> eh) {
			this.evt = eh;
			this.bas = logo;

			System.Threading.Thread.Sleep(1000);
			this.update(10);

			System.Threading.Thread.Sleep(2000);
			this.update(30, Status.Waiting, "Ready");

			System.Threading.Thread.Sleep(2000);
			this.update(50, Status.Running, "Working");

			System.Threading.Thread.Sleep(1000);
			this.update(60, Status.Success, "Finish");

			return true;
		}

	}

}
