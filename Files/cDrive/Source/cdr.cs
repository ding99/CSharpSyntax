using System;
using System.IO;
using System.Text.RegularExpressions;

namespace cDrive {

	public class drives {
		public drives() {
		}

		public void specified_dr(string[] args) {

			Console.WriteLine("=== Function: specified_drs");

			try {
				if(args.Length > 0) {
					DriveInfo din = new DriveInfo(args[0]);
					Console.WriteLine("Drive [" + din.Name + "]  Drive Type [" + din.DriveType + "]");
					if(din.IsReady) {
						Console.WriteLine("  Volume Label [" + din.VolumeLabel + "]");
						Console.WriteLine("  File System  [" + din.DriveFormat + "]");
					}
				}

			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}

		}

		public void all_drs() {

			Console.WriteLine("=== Function: all_drs");

			try {
				DriveInfo[] drs = DriveInfo.GetDrives();

				foreach(DriveInfo di in drs) {
					Console.WriteLine("Drive [" + di.Name + "]  Drive Type [" + di.DriveType + "]");
					if(di.IsReady) {
						Console.WriteLine("  Volume Label [" + di.VolumeLabel + "]");
						Console.WriteLine("  File System  [" + di.DriveFormat + "]");
					}
				}
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}

		}

		public void all_lgdrs() {

			Console.WriteLine("=== Function: all_lgdrs");

			try {
				string[] drs = Environment.GetLogicalDrives();

				foreach(string dil in drs) {
					Console.WriteLine("Drive [" + dil + "]");
					DriveInfo di = new DriveInfo(dil);
					Console.WriteLine("  Drive [" + di.Name + "]  Drive Type [" + di.DriveType + "]");
					if(di.IsReady) {
						Console.WriteLine("  Volume Label [" + di.VolumeLabel + "]");
						Console.WriteLine("  File System  [" + di.DriveFormat + "]");
					}
				}
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}

		}

		public void isDr(string s) {
			if(String.IsNullOrWhiteSpace(s)) return;

			Regex regex = new Regex(@"^([a-zA-Z]):\S*");
			Console.WriteLine("=== isDrive [" + s + "] " + regex.IsMatch(s));
		}

		public void drInfo(string s) {
			if(String.IsNullOrWhiteSpace(s)) return;

			//Regex regex = new Regex(@"^([a-zA-Z]):\S*");
			Console.WriteLine("=== isDrive [" + s + "] " + (new Regex(@"^([a-zA-Z]):\S*")).IsMatch(s));

			if(s.Length < 2) return;

			try {
				DriveInfo din = new DriveInfo(s.Substring(0, 2));
				Console.WriteLine("Drive [" + din.Name + "]  Drive Type [" + din.DriveType + "]");
				if(din.IsReady) {
					Console.WriteLine("  Volume Label [" + din.VolumeLabel + "]");
					Console.WriteLine("  File System  [" + din.DriveFormat + "]");
				}
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	
	}

	class Entrence {
		
		static void Main(string[] args) {
			drives ds = new drives();

			//ds.all_drs();
			//ds.specified_dr(args);
			//ds.all_lgdrs();

			//if(args.Length > 0)
			//    ds.isDr(args[0]);

			if(args.Length > 0)
				ds.drInfo(args[0]);
		}

	}

}
