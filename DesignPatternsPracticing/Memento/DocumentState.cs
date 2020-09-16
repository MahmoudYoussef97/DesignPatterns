namespace DesignPatternsPracticing
{
    public class DocumentState
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }
        public DocumentState(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }
    }
}