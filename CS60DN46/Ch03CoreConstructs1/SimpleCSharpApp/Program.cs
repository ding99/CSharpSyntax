﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("**** My First C# App *****");
			Console.WriteLine("Hello Core Constructure I!");
			Console.WriteLine();

			string[] theArgs = Environment.GetCommandLineArgs();
			foreach (string arg in theArgs)
				Console.WriteLine("Arg: {0}", arg);

		}
	}
}
