using System;

namespace CustomException
{
	public class CarIsDeadException : ApplicationException
	{
		private string messageDetails = String.Empty;

		public DateTime ErrorTimeStamp { get; set; }
		public string CauseOfError { get; set; }

		public CarIsDeadException() { }
		public CarIsDeadException(string message, string cause, DateTime time)
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
