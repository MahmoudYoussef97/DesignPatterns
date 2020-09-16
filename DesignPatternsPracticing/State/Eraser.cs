using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.State
{
    public class Eraser : IToolType
    {
        public void MouseUp()
        {
            Console.WriteLine("Eraser Icon");
        }
        public void MouseDown()
        {
            Console.WriteLine("Erasing ...");
        }
    }
}
