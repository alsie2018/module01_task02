using FileComparer.exception;
using System.IO;

namespace FileComparer.comparer
{
    public class AbstractFile<T>
    {
        public string FilePath { get; }
        public string FileNameWithoutExtension { get; }
        public string FileExtension { get; }
        public long FileSizeInBytes { get; }
        public T FileContent { get; }

        public AbstractFile(string filePath, T fileContent, long fileSizeInBytes)
        {
            this.FilePath = filePath;
            this.FileContent = fileContent;
            this.FileNameWithoutExtension = this.GetFileNameWithoutExtension(filePath);
            this.FileExtension = this.GetFileExtension(filePath);
            this.FileSizeInBytes = fileSizeInBytes;
        }

        private string GetFileExtension(string filePath)
        {
            string fileExtension = Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(fileExtension))
            {
                throw new NullOrEmptyFileExtensionException();
            }
            
            return fileExtension;
        }

        private string GetFileNameWithoutExtension(string filePath)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            if (string.IsNullOrEmpty(fileNameWithoutExtension))
            {
                throw new NullOrEmptyFileNameException();
            }

            return fileNameWithoutExtension;
        }
    }
}
