using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MagicEightBallServiceLib {
	[ServiceContract]
	public interface IEightBall {
		[OperationContract]
		string ObtainAnswerToQuestion(string userQuestion);
	}
}
