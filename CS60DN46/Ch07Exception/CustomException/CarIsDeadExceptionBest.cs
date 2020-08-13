using System;
using System.Runtime.Serialization;

namespace CustomException
{
	[Serializable]
	class CarIsDeadExceptionBest : ApplicationException
	{
		public CarIsDeadExceptionBest() { }
		public CarIsDeadExceptionBest(string message) : base(message) { }
		public CarIsDeadExceptionBest(string message, Exception inner) : base(message, inner) { }
		protected CarIsDeadExceptionBest(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
