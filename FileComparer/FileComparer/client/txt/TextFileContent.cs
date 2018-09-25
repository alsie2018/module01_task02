using System.Collections.Generic;

namespace FileComparer.client.txt
{
    public class TextFileContent
    {
        public Dictionary<int, string> TextLines { get; }

        public TextFileContent()
        {
            this.TextLines = new Dictionary<int, string>();
        }

        public void AddTextLine(int line, string textLine)
        {
            this.TextLines.Add(line, textLine);
        }
    }
}
