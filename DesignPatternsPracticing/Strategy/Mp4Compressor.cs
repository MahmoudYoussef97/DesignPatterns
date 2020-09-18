using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Strategy
{
    public class Mp4Compressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"{fileName}.Mp4");
        }
    }
}
