using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.State
{
    public class Canvas
    {
        public IToolType CurrentTool { get; set; }
        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }
        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }
    }
}
