using FileComparer.comparer;
using System.IO;

namespace FileComparer.client.txt
{
    public class TextFileContentCreator : FileContentCreator<TextFileContent>
    {
        public TextFileContent Create(string path)
        {
            TextFileContent textFileContent = new TextFileContent();
            StreamReader file = new StreamReader(path);
            int line = 0;
            string textLine;

            while ((textLine = file.ReadLine()) != null)
            {
                textFileContent.AddTextLine(line, textLine);
                line++;
            }

            file.Close();

            return textFileContent;
        }
    }
}
