using System;
using System.Runtime.Serialization;

namespace MultipleException
{
	class CarIsDeadException : ApplicationException
	{
		public CarIsDeadException() { }
		public CarIsDeadException(string message) : base(message) { }
		public CarIsDeadException(string message, Exception inner) : base(message, inner) { }
		protected CarIsDeadException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
