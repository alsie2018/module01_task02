using System;

namespace FileComparer.exception
{
    [Serializable]
    public class NullOrEmptyFileNameException : Exception
    {
        public NullOrEmptyFileNameException()
            : base("The file name is null or empty.")
        {
        }
    }
}
