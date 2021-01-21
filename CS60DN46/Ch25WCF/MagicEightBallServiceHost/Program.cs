using MagicEightBallServiceLib;
using System;
using System.ServiceModel;

namespace MagicEightBallServiceHost {
	class Program {
		static void Main() {
			Console.WriteLine("***** Console Based WCF Host *****");

			using(ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService))) {
				serviceHost.Open();
				Console.WriteLine("The service is ready.");
				Console.WriteLine("Press the Enter key to terminate service.");
				Console.ReadLine();
			}
		}
	}
}
