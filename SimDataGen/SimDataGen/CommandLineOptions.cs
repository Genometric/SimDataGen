using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace VahidJalili.Di4.SimDataGen
{
    internal class CommandLineOptions
    {
        [Option('c', "count", Required = true, HelpText = "Sets the number of artificial replicates to be generated.")]
        public int sampleCount { set; get; }

        [Option('i', "interval", Required = true, HelpText = "Sets the maximum number of intervals to be generated for each sample.")]
        public int maxICount { set; get; }

        [Option('r', "chr", Required = true, HelpText = "Sets the number of chromosomes to be generated.")]
        public int chrCount { set; get; }


        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
