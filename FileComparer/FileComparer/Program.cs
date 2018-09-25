using CsvHelper;
using FileComparer.client.csv;
using FileComparer.client.txt;
using FileComparer.comparer;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileComparer
{
    class Program
    {
        private const string INPUT_BASE_PATH = @"..\..\input\";
        private const string OUTPUT_BASE_PATH = @"..\..\output\";
        
        static string GetOuputPath(string prefix)
        {
            DateTime currentDateTime = DateTime.Now;
            return string.Concat(OUTPUT_BASE_PATH, prefix, Guid.NewGuid().ToString("N"), ".txt");
        }

        static void Main(string[] args)
        {
            string textPathA = string.Concat(INPUT_BASE_PATH, "GradesA.txt");
            string textPathB = string.Concat(INPUT_BASE_PATH, "GradesB.txt");
            string textPathAA = string.Concat(INPUT_BASE_PATH, "GradesAA.txt");
            string textPathBB = string.Concat(INPUT_BASE_PATH, "GradesBB.txt");
            string csvPathA = string.Concat(INPUT_BASE_PATH, "GradesA.csv");
            string csvPathB = string.Concat(INPUT_BASE_PATH, "GradesB.csv");
            string csvPathAA = string.Concat(INPUT_BASE_PATH, "GradesAA.csv");
            string csvPathBB = string.Concat(INPUT_BASE_PATH, "GradesBB.csv");
            string biblePathA = string.Concat(INPUT_BASE_PATH, "HolyBibleA.txt");
            string biblePathB = string.Concat(INPUT_BASE_PATH, "HolyBibleB.txt");

            // Implementation of TextComparer
            GenericFileComparer<TextFileContent> txtComparer = new GenericFileComparer<TextFileContent>(new TextFileContentCreator(), new TextFileComparer());
            txtComparer.Compare(textPathAA, textPathBB, GetOuputPath("TEXT"));
            txtComparer.Compare(biblePathA, biblePathB, GetOuputPath("BIBLE"));

            // Implementation of CsvComparer
            GenericFileComparer<CsvFileContent<CsvStudent>> csvComparer = new GenericFileComparer<CsvFileContent<CsvStudent>>(new CsvFileContentCreator<CsvStudent>(), new CsvStudentFileComparer());
            csvComparer.Compare(csvPathAA, csvPathBB, GetOuputPath("CSV"));
        }
    }
}
