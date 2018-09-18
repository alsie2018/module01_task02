using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparer
{
    public class CsvFile : XFile
    {
        public override string OpenFile()
        {
            string text = String.Empty;
            try
            {
                text = File.ReadAllText(this.Path, Encoding.UTF8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return text;
        }
    }
}
