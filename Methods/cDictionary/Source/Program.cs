﻿using System;

namespace cDictionary.Source
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("start");

			ExamingDictionary td = new ExamingDictionary();
			bool ret = false;

			ret = td.getStr();
			ret = td.launch();
			ret = td.corrupt();

			DRussian dr = new DRussian();
			ret = dr.accMulti();

			Console.WriteLine(ret ? "Succeeded" : "Failed");
		}
	}
}
