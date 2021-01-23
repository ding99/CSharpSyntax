using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MathServiceLib;
using System.ServiceModel;

namespace MathWindowsServiceHost {
	public partial class MathWinService : ServiceBase {
		private ServiceHost myHost;

		public MathWinService() {
			InitializeComponent();
		}

		protected override void OnStart(string[] args) {
			if(myHost != null) {
				myHost.Close();
				myHost = null;
			}

			myHost = new ServiceHost(typeof(MathService));

			Uri address = new Uri("http://localhost:8080/MathServiceLib");
			WSHttpBinding binding = new WSHttpBinding();
			Type contract = typeof(IBasicMath);

			myHost.AddServiceEndpoint(contract, binding, address);

			myHost.Open();
		}
/*
		protected override void OnStart(string[] args) {
			if (myHost != null)
				myHost.Close();

			myHost = new ServiceHost(typeof(MethSerive), new Uri("http://localhost:8080/MathServiceLib"));

			myHost.AddDefaultEndpoints();

			myHost.Open();
		}
*/
		protected override void OnStop() {
			if (myHost != null)
				myHost.Close();
		}
	}
}
