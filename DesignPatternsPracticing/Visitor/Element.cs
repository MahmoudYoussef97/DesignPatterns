using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Visitor
{
    public interface IElement
    {
        void Execute(IOperation operation);
    }
}
