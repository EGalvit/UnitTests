using System;
using System.IO;

namespace FileHandling
{
    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("filename");
            }
            return File.Exists(fileName);
        }

        public string FileContent(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}
