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
            var simData = new Di4DataSim(Environment.CurrentDirectory);
            simData.Generate(
                sampleCount: 20,
                maxICount: 1000,
                chrCount: 23,
                kDis: new ErlangDistribution(1, 20),
                lambdaDis: new ErlangDistribution(1, 2),
                fileSizeProb: 5);
        }
    }
}
