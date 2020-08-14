using System;

namespace CustomException
{
	public class CarIsDeadException1 : ApplicationException
	{
		private string messageDetails = String.Empty;

		public DateTime ErrorTimeStamp { get; set; }
		public string CauseOfError { get; set; }

		public CarIsDeadException1() { }
		public CarIsDeadException1(string message, string cause, DateTime time)
		{
			messageDetails = message;
			CauseOfError = cause;
			ErrorTimeStamp = time;
		}

		public override string Message {
			get {
				return string.Format($"Car Error Message: {messageDetails}");
			}
		}
	}
}
