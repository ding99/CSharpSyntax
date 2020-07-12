using System;

namespace cFile
{
	class Entrance {
		static void Main(string[] args) {
			Files f = new Files();

			bool ret = false;
			
			//ret = f.filecopy();
			ret = f.names();

			//if(args.Length > 0) ret = f.finfo(args[0]);

			Console.WriteLine(ret ? "Successful" : "Failed");
		}
	}
}
