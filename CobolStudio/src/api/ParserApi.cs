using MyChatDB;
using System;
using System.IO;

namespace CobolStudio.src.api
{
    internal class ParserApi
    {
        public string ParseFile(string fileName)
        {
            if (!fileName.EndsWith(".cobol"))
                fileName += ".cobol";
            var scriptsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "files/cbl");
            var fullPath = Path.Combine(scriptsPath, fileName);
            var exists = File.Exists(fullPath);
            if (!exists)
                return $"File not found: {fullPath}";
            var code = File.ReadAllText(fullPath);
            PrintLn($"Read {code.Length} characters from {fileName}");
            return $"Parsed COBOL file: {fileName}";
        }

        void PrintLn(string message)
        {
            TranscriptWindow.GetInstance().PrintLn(message);
        }
    }
}
