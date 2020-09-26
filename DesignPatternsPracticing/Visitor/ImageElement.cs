using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Visitor
{
    public class ImageElement : IElement
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
