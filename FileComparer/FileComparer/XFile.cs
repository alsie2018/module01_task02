using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparer
{
    public abstract class XFile
    {
        public string Path { get; set; }
        public string FileName { get; set; }

        public long Size { get; set; }

        public abstract string OpenFile();
    }
}
