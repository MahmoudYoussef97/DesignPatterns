using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Template
{
    public abstract class Window
    {
        public void Close()
        {
            BeforeClosing();
            Console.WriteLine("Window is closed.");
            AfterClosing();
        }
        protected abstract void BeforeClosing();
        protected abstract void AfterClosing();
    }
}
