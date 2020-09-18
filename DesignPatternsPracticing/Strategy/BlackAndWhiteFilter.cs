using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void ApplyFilter(string fileName)
        {
            Console.WriteLine($"Applying Black & White Filter on {fileName}");
        }
    }
}
