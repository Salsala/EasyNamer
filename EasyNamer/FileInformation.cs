using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyNamer
{
    public class FileInformation
    {
        public string 파일명 { get; set; }
        public string 확장자 { get; set; }
        public string 경로 { get; set; }
        public FileInformation(string filename, string extension, string fullname)
        {
            this.파일명 = filename;
            this.확장자 = extension;
            this.경로 = fullname;
        }
    }
}
