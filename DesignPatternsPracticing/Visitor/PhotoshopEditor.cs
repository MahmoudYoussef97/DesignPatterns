using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Visitor
{
    public class PhotoshopEditor
    {
        private List<IElement> elements = new List<IElement>();
        public void Use(IElement element)
        {
            elements.Add(element);
        }
        public void Execute(IOperation operation)
        {
            foreach (var element in elements)
            {
                element.Execute(operation);
            }
        }
    }
}
