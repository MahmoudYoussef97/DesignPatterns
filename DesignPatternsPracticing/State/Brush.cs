using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.State
{
    public class Brush : IToolType
    {
        public void MouseUp()
        {
            Console.WriteLine("Brush Icon");
        }
        public void MouseDown()
        {
            Console.WriteLine("Draw a solid line");
        }
    }
}
