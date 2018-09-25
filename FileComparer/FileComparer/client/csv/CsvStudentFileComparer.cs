using System.Collections.Generic;
using System.Text;
using FileComparer.comparer;

namespace FileComparer.client.csv
{
    public class CsvStudentFileComparer : CsvFileComparer<CsvStudent>
    {
        public string Compare(AbstractFile<CsvFileContent<CsvStudent>> fileA, AbstractFile<CsvFileContent<CsvStudent>> fileB)
        {
            StringBuilder differences = new StringBuilder();
            
            List<CsvStudent> studentsA = fileA.FileContent.Records;
            List<CsvStudent> studentsB = fileB.FileContent.Records;
            CsvStudent studentB;

            foreach (CsvStudent studentA in studentsA)
            {
                studentB = FindCsvStudent(studentsB, studentA.Id);
                if (!AreEquals(studentA, studentB))
                {
                    differences.AppendLine(GetDifference(studentA.Id));
                }
            }
            
            return differences.ToString();
        }
        
        private bool AreEquals(CsvStudent studentA, CsvStudent studentB)
        {
            return (
                   (studentA.FirstName == studentB.FirstName)
                && (studentA.LastName == studentB.LastName)
                && (studentA.Grade == studentB.Grade)
            );
        }

        private CsvStudent FindCsvStudent(List<CsvStudent> students, long id)
        {
            CsvStudent csvStudent = null;
            int index = students.FindIndex(x => x.Id == id);
            if (index >= 0)
            {
                csvStudent = students[index];
            }
            return csvStudent;
        }

        private string GetDifference(long id)
        {
            return string.Format("The CsvStudents with Id={0} don't match!", id);
        }
    }
}
