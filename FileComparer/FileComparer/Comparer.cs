using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparer
{
    public class Comparer
    {
        private const string OUTPUT_BASE_PATH = @"..\..\output\";

        public void CompareByContent(CsvFile a, CsvFile b)
        {
            Console.WriteLine("Comparing two CsvFiles...");

            string contentA = a.OpenFile();
            string contentB = b.OpenFile();
            string text = string.Empty;

            if (contentA == contentB)
            {
                text = string.Format("The file {0} and the file {1} have the same content.", a.FileName, b.FileName);
            }
            else
            {
                text = string.Format("The file {0} and the file {1} have not the same content.", a.FileName, b.FileName);
            }

            DateTime currentDateTime = DateTime.Now;
            string path = string.Concat(OUTPUT_BASE_PATH, currentDateTime.ToString("YYYY.MM.dd.hh.mm.ss"), ".txt");
            try
            {
                File.WriteAllText(path, text, Encoding.UTF8);

                Console.WriteLine("Please review the output directory!\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CompareByContent(TextFile a, TextFile b)
        {
            Console.WriteLine("Comparing two TextFiles...");

            string contentA = a.OpenFile();
            string contentB = b.OpenFile();
            string text = string.Empty;

            if (contentA == contentB)
            {
                text = string.Format("The file {0} and the file {1} have the same content.", a.FileName, b.FileName);
            }
            else
            {
                text = string.Format("The file {0} and the file {1} have not the same content.", a.FileName, b.FileName);
            }

            DateTime currentDateTime = DateTime.Now;
            string path = string.Concat(OUTPUT_BASE_PATH, currentDateTime.ToString("YYYY.MM.dd.hh.mm.ss"), ".txt");
            try
            {
                File.WriteAllText(path, text, Encoding.UTF8);

                Console.WriteLine("Please review the output directory!\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CompareBySize(CsvFile a, CsvFile b)
        {
            Console.WriteLine("Comparing two CsvFiles...");

            string text = string.Empty;
            if (a.Size == b.Size)
            {
                text = string.Format("The file {0} and the file {1} have the same size.", a.FileName, b.FileName);
            }
            else
            {
                text = string.Format("The file {0} has a size of {1}, and the file {2} has a size of {3}.", a.FileName, a.Size, b.FileName, b.Size);
            }

            DateTime currentDateTime = DateTime.Now;
            string path = string.Concat(OUTPUT_BASE_PATH, currentDateTime.ToString("YYYY.MM.dd.hh.mm.ss"), ".txt");
            try
            {
                File.WriteAllText(path, text, Encoding.UTF8);

                Console.WriteLine("Please review the output directory!\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CompareBySize(TextFile a, TextFile b)
        {
            Console.WriteLine("Comparing two TextFiles...");

            string text = string.Empty;
            if (a.Size == b.Size)
            {
                text = string.Format("The file {0} and the file {1} have the same size.", a.FileName, b.FileName);
            }
            else
            {
                text = string.Format("The file {0} has a size of {1}, and the file {2} has a size of {3}.", a.FileName, a.Size, b.FileName, b.Size);
            }

            DateTime currentDateTime = DateTime.Now;
            string path = string.Concat(OUTPUT_BASE_PATH, currentDateTime.ToString("YYYY.MM.dd.hh.mm.ss"), ".txt");
            try
            {
                File.WriteAllText(path, text, Encoding.UTF8);

                Console.WriteLine("Please review the output directory!\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
