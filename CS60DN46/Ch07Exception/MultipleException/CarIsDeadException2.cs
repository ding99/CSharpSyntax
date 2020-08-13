using System;

namespace MultipleException
{
	class CarIsDeadException2 : ApplicationException
	{
		public DateTime ErrorTimeStamp { get; set; }
		public string CauseOfError { get; set; }

		public CarIsDeadException2() { }
		public CarIsDeadException2(string message, string cause, DateTime time) : base(message)
		{
			CauseOfError = cause;
			ErrorTimeStamp = time;
		}
	}
}
