using Antlr4.Runtime;

namespace CobolStudio.src.parser
{
    internal class Parser
    {
        static Parser instance = null;
        public static Parser GetInstance()
        {
            if (instance == null)
            {
                instance = new Parser();
            }
            return instance;
        }

        public static string ParseSource(string source)
        {
            AntlrInputStream antlrInput = new AntlrInputStream(source);
            Cobol85Lexer lexer = new Cobol85Lexer(antlrInput);
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            tokenStream.Fill();
            var tokens = tokenStream.GetTokens();
            return $"There are {tokens.Count} tokens from {source.Length} characters";
        }
    }

}
