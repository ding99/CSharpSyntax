using System;
using CommandLine;
using CommandLine.Text;

namespace CCmd {
	class Options {
		[Option('i', "input", Required = true,
		  HelpText = "Input source file.")]
		public string Source { get; set; }

		[Option('o', "output", Required = true,
		  HelpText = "Output destination file.")]
		public string Reference { get; set; }

		[Option('r', "range", DefaultValue = 7200,
		  HelpText = "Range to search.")]
		public int range { get; set; }

		[Option('l', "length", DefaultValue = 481,
		  HelpText = "Length of comparison.")]
		public int length { get; set; }

		[ParserState]
		public IParserState LastParserState { get; set; }

		[HelpOption]
		public string GetUsage() {
			return HelpText.AutoBuild(this,
			  (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
		}
	}

	class Program {
		static void Main(string[] args) {

			Options options = new Options();
			if(!Parser.Default.ParseArguments(args, options)){
				Console.WriteLine("Failed to pasrse command line arguments.");
				return;
			}

			Console.WriteLine("input  [" + options.Source + "]");
			Console.WriteLine("output [" + options.Reference + "]");

			Console.WriteLine("range  [" + options.range + "]");
			Console.WriteLine("length [" + options.length + "]");

		}
	}
}
