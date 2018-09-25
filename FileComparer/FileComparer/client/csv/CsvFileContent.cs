using System.Collections.Generic;

namespace FileComparer.client.csv
{
    public class CsvFileContent<E>
    {
        public List<E> Records { get; }

        public CsvFileContent()
        {
            this.Records = new List<E>();
        }

        public void AddRecord(E record)
        {
            this.Records.Add(record);
        }
    }
}
