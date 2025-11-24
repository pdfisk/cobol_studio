using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using CobolStudio.src.parser;
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
            ICharStream inputStream = new AntlrInputStream(code);
            Cobol85Lexer lexer = new Cobol85Lexer(inputStream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            Cobol85Parser parser = new Cobol85Parser(tokens);
            IParseTree tree = parser.startRule();
            Visitor visitor = new Visitor();
            visitor.Visit(tree);
            return "DONE";
        }

        void PrintLn(string message)
        {
            TranscriptWindow.GetInstance().PrintLn(message);
        }
    }
}
