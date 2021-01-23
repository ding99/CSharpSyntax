using System.ServiceModel;

namespace MathServiceLib {

	[ServiceContract(Namespace ="http://MyCompany.com")]
	public interface IBasicMath {
		[OperationContract]
		int Add(int x, int y);
	}
}
