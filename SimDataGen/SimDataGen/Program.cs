using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VahidJalili.Di4.SimDataGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new CommandLineOptions();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                var simData = new Di4DataSim(Environment.CurrentDirectory);
                simData.Generate(
                    sampleCount: options.sampleCount,
                    maxICount: options.maxICount,
                    chrCount: options.chrCount,
                    kDis: new ErlangDistribution(options.kk, options.kl),
                    lambdaDis: new ErlangDistribution(options.lk, options.ll),
                    fileSizeProb: options.fileSizeProb);
            }
            else
                Console.WriteLine("Invalid arguments");
        }
    }
}
