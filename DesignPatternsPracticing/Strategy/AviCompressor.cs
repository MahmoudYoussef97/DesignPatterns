using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Strategy
{
    public class AviCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"{fileName}.Avi");
        }
    }
}
