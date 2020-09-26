using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Visitor
{
    public class DeleteOperation : IOperation
    {
        public void Apply(ImageElement image)
        {
            Console.WriteLine("Image deleted");
        }

        public void Apply(TextElement text)
        {
            Console.WriteLine("Text deleted");
        }
    }
}
