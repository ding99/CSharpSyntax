namespace CFolder
{
	class Entrance
	{
		static void Main(string[] args)
		{
			FindDirs fdir = new FindDirs();

			string dir = args.Length > 0 ? args[0] : @"C:\CExec\55-smooth\";
			fdir.seekDir(dir);
			fdir.seekDir(dir, @"GroupSmoothStreaming_DRAVCWeb_CBR_Multi_11Layers_DolbyPulse_12_12_54 PM.ism");
			fdir.getfiles(dir);

		}
	}
}
