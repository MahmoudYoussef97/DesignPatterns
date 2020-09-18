using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Strategy
{
    public class VideoStore
    {
        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.ApplyFilter(fileName);
        }
    }
}
