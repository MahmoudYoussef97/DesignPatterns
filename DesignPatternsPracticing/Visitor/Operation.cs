using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Visitor
{
    public interface IOperation
    {
        void Apply(ImageElement image);
        void Apply(TextElement text);
    }
}
