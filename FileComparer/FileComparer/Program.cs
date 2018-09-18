using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileComparer
{
    class Program
    {
        private static string INPUT_BASE_PATH = @"..\..\input\";

        static void Main(string[] args)
        {
            // Compare files by size
            CompareTextFilesBySize();
            Thread.Sleep(2000);

            CompareTextFilesBySize2();
            Thread.Sleep(2000);

            CompareCsvFilesBySize();
            Thread.Sleep(2000);

            CompareCsvFilesBySize2();
            Thread.Sleep(2000);
            

            // Compare files by content
            CompareTextFilesByContent();
            Thread.Sleep(2000);

            CompareTextFilesByContent2();
            Thread.Sleep(2000);

            CompareCsvFilesByContent();
            Thread.Sleep(2000);

            CompareCsvFilesByContent2();
            Thread.Sleep(2000);
        }

        static void CompareTextFilesBySize()
        {
            // Create the FileA and FileB
            TextFile tfa = new TextFile();
            tfa.Path = string.Concat(INPUT_BASE_PATH, "GradesA.txt");
            tfa.FileName = Path.GetFileName(tfa.Path);

            TextFile tfb = new TextFile();
            tfb.Path = string.Concat(INPUT_BASE_PATH, "GradesB.txt");
            tfb.FileName = Path.GetFileName(tfb.Path);

            // Adding data to the new objects
            FileInfo fia = new FileInfo(tfa.Path);
            tfa.Size = fia.Length;

            FileInfo fib = new FileInfo(tfb.Path);
            tfb.Size = fib.Length;

            // Compare those files
            Comparer comparer = new Comparer();
            comparer.CompareBySize(tfa, tfb);
        }

        static void CompareTextFilesBySize2()
        {
            // Create the FileA and FileB
            TextFile tfa = new TextFile();
            tfa.Path = string.Concat(INPUT_BASE_PATH, "GradesAA.txt");
            tfa.FileName = Path.GetFileName(tfa.Path);

            TextFile tfb = new TextFile();
            tfb.Path = string.Concat(INPUT_BASE_PATH, "GradesBB.txt");
            tfb.FileName = Path.GetFileName(tfb.Path);

            // Adding data to the new objects
            FileInfo fia = new FileInfo(tfa.Path);
            tfa.Size = fia.Length;

            FileInfo fib = new FileInfo(tfb.Path);
            tfb.Size = fib.Length;

            // Compare those files
            Comparer comparer = new Comparer();
            comparer.CompareBySize(tfa, tfb);
        }

        static void CompareCsvFilesBySize()
        {
            // Create the FileA and FileB
            CsvFile tfa = new CsvFile();
            tfa.Path = string.Concat(INPUT_BASE_PATH, "GradesA.csv");
            tfa.FileName = Path.GetFileName(tfa.Path);

            CsvFile tfb = new CsvFile();
            tfb.Path = string.Concat(INPUT_BASE_PATH, "GradesB.csv");
            tfb.FileName = Path.GetFileName(tfb.Path);

            // Adding data to the new objects
            FileInfo fia = new FileInfo(tfa.Path);
            tfa.Size = fia.Length;

            FileInfo fib = new FileInfo(tfb.Path);
            tfb.Size = fib.Length;

            // Compare those files
            Comparer comparer = new Comparer();
            comparer.CompareBySize(tfa, tfb);
        }

        static void CompareCsvFilesBySize2()
        {
            // Create the FileA and FileB
            CsvFile tfa = new CsvFile();
            tfa.Path = string.Concat(INPUT_BASE_PATH, "GradesAA.csv");
            tfa.FileName = Path.GetFileName(tfa.Path);

            CsvFile tfb = new CsvFile();
            tfb.Path = string.Concat(INPUT_BASE_PATH, "GradesBB.csv");
            tfb.FileName = Path.GetFileName(tfb.Path);

            // Adding data to the new objects
            FileInfo fia = new FileInfo(tfa.Path);
            tfa.Size = fia.Length;

            FileInfo fib = new FileInfo(tfb.Path);
            tfb.Size = fib.Length;

            // Compare those files
            Comparer comparer = new Comparer();
            comparer.CompareBySize(tfa, tfb);
        }

        static void CompareTextFilesByContent()
        {
            // Create the FileA and FileB
            TextFile tfa = new TextFile();
            tfa.Path = string.Concat(INPUT_BASE_PATH, "GradesA.txt");
            tfa.FileName = Path.GetFileName(tfa.Path);

            TextFile tfb = new TextFile();
            tfb.Path = string.Concat(INPUT_BASE_PATH, "GradesB.txt");
            tfb.FileName = Path.GetFileName(tfb.Path);

            // Compare those files
            Comparer comparer = new Comparer();
            comparer.CompareByContent(tfa, tfb);
        }

        static void CompareTextFilesByContent2()
        {
            // Create the FileA and FileB
            TextFile tfa = new TextFile();
            tfa.Path = string.Concat(INPUT_BASE_PATH, "GradesAA.txt");
            tfa.FileName = Path.GetFileName(tfa.Path);

            TextFile tfb = new TextFile();
            tfb.Path = string.Concat(INPUT_BASE_PATH, "GradesBB.txt");
            tfb.FileName = Path.GetFileName(tfb.Path);

            // Compare those files
            Comparer comparer = new Comparer();
            comparer.CompareByContent(tfa, tfb);
        }

        static void CompareCsvFilesByContent()
        {
            // Create the FileA and FileB
            CsvFile tfa = new CsvFile();
            tfa.Path = string.Concat(INPUT_BASE_PATH, "GradesA.csv");
            tfa.FileName = Path.GetFileName(tfa.Path);

            CsvFile tfb = new CsvFile();
            tfb.Path = string.Concat(INPUT_BASE_PATH, "GradesB.csv");
            tfb.FileName = Path.GetFileName(tfb.Path);
            
            // Compare those files
            Comparer comparer = new Comparer();
            comparer.CompareByContent(tfa, tfb);
        }

        static void CompareCsvFilesByContent2()
        {
            // Create the FileA and FileB
            CsvFile tfa = new CsvFile();
            tfa.Path = string.Concat(INPUT_BASE_PATH, "GradesAA.csv");
            tfa.FileName = Path.GetFileName(tfa.Path);

            CsvFile tfb = new CsvFile();
            tfb.Path = string.Concat(INPUT_BASE_PATH, "GradesBB.csv");
            tfb.FileName = Path.GetFileName(tfb.Path);

            // Compare those files
            Comparer comparer = new Comparer();
            comparer.CompareByContent(tfa, tfb);
        }
    }
}
