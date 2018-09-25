using System;
using System.Text;
using System.Collections.Generic;
using FileComparer.comparer;

namespace FileComparer.client.txt
{
    public class TextFileComparer : AbstractFileComparer<TextFileContent>
    {
        public string Compare(AbstractFile<TextFileContent> fileA, AbstractFile<TextFileContent> fileB)
        {
            StringBuilder differences = new StringBuilder();

            Dictionary<int, string> textLinesA = fileA.FileContent.TextLines;
            Dictionary<int, string> textLinesB = fileB.FileContent.TextLines;
            int maxLines = Math.Max(textLinesA.Count, textLinesB.Count);
            string textLineA;
            string textLineB;

            for (int i = 0; i < maxLines; i++)
            {
                textLineA = GetTextLine(textLinesA, i);
                textLineB = GetTextLine(textLinesB, i);

                if (textLineA != textLineB)
                {
                    differences.AppendLine(GetDifference(i, textLineA, textLineB));
                }
            }

            return differences.ToString();
        }
        
        private string GetTextLine(Dictionary<int, string> textLines, int line)
        {
            string textLine;
            if (textLines.TryGetValue(line, out textLine))
            {
                return textLine;
            }
            else
            {
                return string.Empty;
            }
        }

        private string GetDifference(int index, string textLineA, string textLineB)
        {
            return string.Format("Line: {0}\t-->\tA({1}) DISTINCT OF B({2})", index, textLineA, textLineB);
        }
    }
}
