using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class StartNode:AstNode
    {
        StartRuleContext _context;

        public StartNode(StartRuleContext context)
        {
            _ctx = _context = context;
        }

    }
}
