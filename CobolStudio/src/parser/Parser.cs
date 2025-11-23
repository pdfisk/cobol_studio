using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using CobolStudio.src.parser.ast;
using System.Collections.Generic;
using static Cobol85Parser;

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

        public object ParseSource(string source)
        {
            CommonTokenStream tokenStream = GetTokenStream(source);
            Cobol85Parser parser = new Cobol85Parser(tokenStream);
            StartRuleContext startRuleContext = parser.startRule();
            var visitor = new Visitor();
            return visitor.Visit(startRuleContext);
        }

        public List<IToken> GetAllTokens(string source)
        {
            CommonTokenStream tokenStream = GetTokenStream(source);
            tokenStream.Fill();
            var tokens = tokenStream.GetTokens();
            var tokenList = new List<IToken>(tokens);
            return tokenList;
        }

        CommonTokenStream GetTokenStream(string source)
        {
            AntlrInputStream antlrInput = new AntlrInputStream(source);
            Cobol85Lexer lexer = new Cobol85Lexer(antlrInput);
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            return tokenStream;
        }

        AstNode BuildAst(RuleContext context)
        {
            if (context is IRuleNode )
                return CreateRuleNode(context);
            else if (context is ITerminalNode)
                return CreateTerminalNode((ITerminalNode)context);
            else if (context is IErrorNode)
                return CreateErrorNode((IErrorNode)context);
            return new AstNode();
        }

        AstNode CreateErrorNode(IErrorNode errorNode)
        {
            return new AstNode();
        }

        AstNode CreateRuleNode(RuleContext context)
        {
            return new AstNode();
        }

        AstNode CreateTerminalNode(ITerminalNode terminalNode)
        {
            return new AstNode();
        }

    }

}
