using System;

namespace cEnvironment {

	public class Env {
		public void encVari(){
			Console.WriteLine("Environment.MachineName                            : " + Environment.MachineName);
			Console.WriteLine("System.Net.Dns.GetHostName                         : " + System.Net.Dns.GetHostName());
			Console.WriteLine("System.Windows.Forms.SystemInformation.ComputerName: " + System.Windows.Forms.SystemInformation.ComputerName);
			Console.WriteLine("System.Environment.GetEnvironmentVariable          : " + System.Environment.GetEnvironmentVariable("COMPUTERNAME"));
			Console.WriteLine("System.Net.Dns.GetHostEntry().HostName             : " + System.Net.Dns.GetHostEntry("").HostName);
			Console.WriteLine("TempFileName                                       : " + System.IO.Path.GetTempFileName());
		}

		public void display() {
			System.Diagnostics.Debug.WriteLine("ABC");
			System.Windows.Forms.MessageBox.Show("ABC by Window");
		}

        public void seten() {
            Console.WriteLine($"Self Env [{Environment.GetEnvironmentVariable("SELF_ENV")}] is-null [{string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("SELF_ENV"))}]");

            Environment.SetEnvironmentVariable("SELF_ENV", "self_variable");

            Console.WriteLine($"Self Env [{Environment.GetEnvironmentVariable("SELF_ENV")}] is-null [{string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("SELF_ENV"))}]");
        }
    }

}
