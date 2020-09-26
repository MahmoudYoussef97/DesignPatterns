using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Visitor
{
    public class TextElement : IElement
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
