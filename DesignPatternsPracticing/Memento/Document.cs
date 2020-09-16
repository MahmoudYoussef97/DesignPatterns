using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPracticing
{
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public DocumentState CreateState()
        {
            return new DocumentState(this.Content, this.FontName, this.FontSize);
        }
        public void RestoreState(DocumentState documentState)
        {
            Content = documentState.Content;
            FontName = documentState.FontName;
            FontSize = documentState.FontSize;
        }
    }
}
