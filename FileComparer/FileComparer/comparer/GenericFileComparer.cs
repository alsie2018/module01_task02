using System;
using System.IO;
using System.Text;

namespace FileComparer.comparer
{
    public class GenericFileComparer<T>
    {
        private FileContentCreator<T> FileCreator;
        private AbstractFileComparer<T> FileComparer;

        public GenericFileComparer(FileContentCreator<T> fileCreator, AbstractFileComparer<T> fileComparer)
        {
            this.FileCreator = fileCreator;
            this.FileComparer = fileComparer;
        }

        public void Compare(string firstPath, string secondPath, string outputPath)
        {
            try
            {
                T firstFileContent = this.FileCreator.Create(firstPath);
                T secondFileContent = this.FileCreator.Create(secondPath);

                AbstractFile<T> firstAbstractFile = this.CreateAbstractFile(firstPath, firstFileContent);
                AbstractFile<T> secondAbstractFile = this.CreateAbstractFile(secondPath, secondFileContent);

                string result = this.FileComparer.Compare(firstAbstractFile, secondAbstractFile);
                this.ExportResult(result, outputPath);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private AbstractFile<T> CreateAbstractFile(string path, T abstractFileContent)
        {
            FileInfo fileInfo = new FileInfo(path);
            return new AbstractFile<T>(path, abstractFileContent, fileInfo.Length);
        }

        private void ExportResult(string result, string outputPath)
        {
            File.WriteAllText(outputPath, result, Encoding.UTF8);
        }
    }
}
