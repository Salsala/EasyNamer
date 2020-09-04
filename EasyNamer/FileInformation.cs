namespace EasyNamer
{
    public class FileInformation
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Directory { get; set; }
        public FileInformation(string filename, string extension, string directory)
        {
            FileName = filename;
            Extension = extension;
            Directory = directory;
        }
    }
}
