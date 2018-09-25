using CsvHelper;
using FileComparer.comparer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparer.client.csv
{
    class CsvFileContentCreator<E> : FileContentCreator<CsvFileContent<E>>
    {
        public CsvFileContent<E> Create(string path)
        {
            CsvFileContent<E> fileContent = new CsvFileContent<E>();
            using (var sr = new StreamReader(path))
            {
                var csv = new CsvReader(sr);
                var records = csv.GetRecords<E>();
                foreach (E record in records)
                {
                    fileContent.AddRecord(record);
                }
            }

            return fileContent;
        }
    }
}
