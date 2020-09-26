using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Visitor
{
    public class ResizeOperation : IOperation
    {
        public void Apply(ImageElement image)
        {
            Console.WriteLine("Image resized");
        }

        public void Apply(TextElement text)
        {
            Console.WriteLine("Text resized");
        }
    }
}
