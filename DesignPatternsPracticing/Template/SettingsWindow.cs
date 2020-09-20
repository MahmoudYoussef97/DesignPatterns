using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing.Template
{
    public class SettingsWindow : Window
    {
        protected override void AfterClosing()
        {
            Console.WriteLine("Applying the new changes..");
        }
        protected override void BeforeClosing()
        {
            Console.WriteLine("Saving changes..");
        }
    }
}
