﻿namespace CDrive
{
	class Entrence {
		
		static void Main(string[] args) {
			Drives ds = new Drives();

			ds.all_drs();
			ds.specified_dr(args);
			ds.all_lgdrs();

			if (args.Length > 0)
				ds.isDr(args[0]);

			if (args.Length > 0)
				ds.drInfo(args[0]);
		}

	}

}
