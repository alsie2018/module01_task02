using System;

namespace FileComparer.exception
{
    [Serializable]
    public class NullOrEmptyFileExtensionException : Exception
    {
        public NullOrEmptyFileExtensionException()
            : base("The file extension is null or empty.")
        {
        }
    }
}
