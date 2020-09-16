using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.State
{
    public class Selection : IToolType
    {
        public void MouseUp()
        {
            Console.WriteLine("Selection Icon");
        }
        public void MouseDown()
        {
            Console.WriteLine("Drawing a dashed line");
        }
    }
}
