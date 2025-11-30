using Antlr4.Runtime;
using CobolStudio.src.compiler.core;
using CobolStudio.src.parser;
using System;
using System.IO;
using System.Reflection;

namespace CobolStudio.src.compiler
{
    internal class CobolCompiler
    {
        public static string CompileFile(string fileName)
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
            var parser = new CobolParser(tokens);
            var ast = parser.BuildAst();
            //parser.PrintLn(ast.ToTree());
            CompilerUtil compilerUtil = new CompilerUtil();
            return ast.Generate(compilerUtil).ToString();
        }

    }
}

//Missing GenerateSelf DisplayStatementNode: 1
//Missing GenerateSelf DisplayOperandNode: 1
//Missing GenerateSelf LiteralNode: 0
//Missing GenerateSelf StopStatementNode: 0
//Missing GenerateSelf DisplayStatementNode: 1
//Missing GenerateSelf DisplayOperandNode: 1
//Missing GenerateSelf LiteralNode: 0
//Missing GenerateSelf StopStatementNode: 0




