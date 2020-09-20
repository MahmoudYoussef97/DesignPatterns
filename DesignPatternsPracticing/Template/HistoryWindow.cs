using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Template
{
    public class HistoryWindow : Window
    {
        protected override void AfterClosing()
        {
            Console.WriteLine("Do nothing");
        }
        protected override void BeforeClosing()
        {
            Console.WriteLine("Do nothing");
        }
    }
}
