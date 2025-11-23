using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class StartNode:AstNode
    {

        public StartNode(StartRuleContext context)
        {
            ctx = context;
        }

    }
}
