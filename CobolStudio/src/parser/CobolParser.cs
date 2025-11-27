using Antlr4.Runtime;
using CobolStudio.src.parser.ast;
using MyChatDB;

namespace CobolStudio.src.parser
{
    internal class CobolParser : Cobol85Parser
    {
        ITokenStream input_stream;

        public CobolParser(ITokenStream input_arg) : base(input_arg)
        {
            input_stream = input_arg;
        }

        public AstNode BuildAst()
        {
            var context = startRule();
            return BuildAst(context);
        }

        AstNode BuildAst(RuleContext context)
        {
            AstNode node = null;
            if (context == null)
                return null;
            // start
            if (context is StartRuleContext)
                node = new StartRuleNode((StartRuleContext)context);
            else if (context is ProgramUnitContext)
                node = new ProgramUnitNode((ProgramUnitContext)context);
            else if (context is EndProgramStatementContext)
                node = new EndPrgramStatementNode((EndProgramStatementContext)context);
            // identification division
            else if (context is IdentificationDivisionContext)
                node = new IdentificationDivisionNode((IdentificationDivisionContext)context);
            if (node != null)
            {
                for (var i = 0; i < context.ChildCount; i++)
                {
                    var child = context.GetChild(i);
                    if (child is RuleContext)
                    {
                        var childNode = BuildAst((RuleContext)child);
                        if (childNode != null)
                            node.AddChild(childNode);
                    }
                }
                return node;
            }
            var message = context.GetType().ToString();
            PrintLn(message);
            return new ErrorNode(context, message);
        }

        void PrintLn(string message)
        {
            TranscriptWindow.GetInstance().PrintLn(message);
        }
    }
}
