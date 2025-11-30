using Antlr4.Runtime;

namespace CobolStudio.src.parser.ast
{
    public class ErrorNode : AstNode
    {
        string message;

        public ErrorNode(RuleContext context, string message_arg)
        {
            _ctx = context;
            message = message_arg;
        }

        public override string ToString()
        {
            return $"Error: {message}";
        }
    }
}
