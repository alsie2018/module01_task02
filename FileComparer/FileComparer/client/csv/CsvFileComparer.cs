using FileComparer.comparer;

namespace FileComparer.client.csv
{
    public interface CsvFileComparer<E> : AbstractFileComparer<CsvFileContent<E>>
    {
    }
}
