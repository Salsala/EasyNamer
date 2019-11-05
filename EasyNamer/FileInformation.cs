using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyNamer
{
    public class FileInformation
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Directory { get; set; }
        public FileInformation(string filename, string extension, string directory)
        {
            this.FileName = filename;
            this.Extension = extension;
            this.Directory = directory;
        }
    }
}
