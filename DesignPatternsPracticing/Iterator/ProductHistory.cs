using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Iterator
{
    public class ProductHistory
    {
        public Stack<string> Products { get; } = new Stack<string>();
        public void Push(string product)
        {
            Products.Push(product);
        }
        public string Pop()
        {
            return Products.Pop();
        }
        public IIterator<string> CreateIterator()
        {
            return new StackIterator(this);
        }
    }
}
