namespace FileComparer.comparer
{
    public interface FileContentCreator<T>
    {
        T Create(string path);
    }
}
