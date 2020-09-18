using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Strategy
{
    public class HighContrastFilter : IFilter
    {
        public void ApplyFilter(string fileName)
        {
            Console.WriteLine($"Applying High Contrast Filter on {fileName}");
        }
    }
}
