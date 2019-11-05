using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyNamer
{
    public enum FileTypes
    {
        Video,
        Subtitle
    }

    public class FileType
    {
        public FileTypes fileType;
        public string[] ExtensionList;
        public string filter;

        public FileType(FileTypes fileType)
        {
            this.fileType = fileType;

            switch (this.fileType)
            {
                case FileTypes.Video:
                    ExtensionList =new string[]{ ".mp4", ".mkv", ".avi"};
                    filter = "동영상 파일(*.mp4, *.mkv, *.avi)|*.mp4;*.mkv;*.avi";
                    break;
                case FileTypes.Subtitle:
                    ExtensionList = new string[] { ".smi", ".ass", ".str" };
                    filter = "자막 파일(*.smi, *.ass, *.str)|*.smi;*.ass;*.str";
                    break;
            }
        }
    }
}
