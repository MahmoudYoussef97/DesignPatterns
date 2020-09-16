using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Iterator
{
    public class StackIterator : IIterator<string>
    {
        private ProductHistory products;
        private int index;
        public StackIterator(ProductHistory productHistory)
        {
            products = productHistory;
            index = productHistory.Products.Count;
        }
        public string Current()
        {
            return products.Products.ToArray()[index - 1];
        }
        public bool HasNext()
        {
            return index > 0;
        }

        public void Next()
        {
            index--;
        }
    }
}
