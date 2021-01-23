using MagicEightBallServiceLib;
using System;
using System.ServiceModel;

namespace MagicEightBallServiceHost {
	class Program {
		static void Main() {
			Console.WriteLine("***** Console Based WCF Host *****");

			using(ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService))) {
				serviceHost.Open();

				DisplayHostInfo(serviceHost);

				Console.WriteLine("The service is ready.");
				Console.WriteLine("Press the Enter key to terminate service.");
				Console.ReadLine();
			}
		}

		static void DisplayHostInfo(ServiceHost host) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("==> Host Info");
			
			Console.WriteLine($"BaseAddresses (count {host.BaseAddresses.Count}) :");
			foreach(var a in host.BaseAddresses)
				Console.WriteLine($"  {a.Scheme} | {a.Host} | {a.Port} | {a.AbsolutePath}");

			Console.WriteLine($"Endpoints (count {host.Description.Endpoints.Count}) :");
			foreach (System.ServiceModel.Description.ServiceEndpoint e in host.Description.Endpoints) {
				Console.WriteLine($"  Address : {e.Address}");
				Console.WriteLine($"  Binding : {e.Binding.Name}");
				Console.WriteLine($"  Contract: {e.Contract.Name}");
				Console.WriteLine($"  Receive Timeout : {e.Binding.ReceiveTimeout}");
				Console.WriteLine($"  Send    Timeout : {e.Binding.SendTimeout}");
				Console.WriteLine($"  Open    Timeout : {e.Binding.OpenTimeout}");
				Console.WriteLine($"  Close   Timeout : {e.Binding.CloseTimeout}");
			}
			Console.ResetColor();
		}
	}
}
