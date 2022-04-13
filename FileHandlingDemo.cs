using System;

using System.IO;

namespace FinanceApp
{
    internal class FileHandlingDemo
    {

        internal void GetFileInfo(string filePath) {
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine($"{fileInfo.CreationTime}, FilePath: {fileInfo.DirectoryName}");
        }

        internal void CreateLog(string fileName,string filePath) {
            File.Create($"{filePath}/{fileName}");
            Console.WriteLine("File created successfully");
        }

        internal void Log(string file,string logMsg,string logType) {
            File.AppendAllText(file, $"{DateTime.Today}\t:{logType}\t:{logMsg}\n");
        }

    }
}
