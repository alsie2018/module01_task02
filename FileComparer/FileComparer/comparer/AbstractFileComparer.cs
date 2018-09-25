namespace FileComparer.comparer
{
    public interface AbstractFileComparer<T>
    {
        string Compare(AbstractFile<T> fileA, AbstractFile<T> fileB);
    }
}
