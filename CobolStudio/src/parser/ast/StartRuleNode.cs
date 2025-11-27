using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class StartRuleNode : AstNode
    {
        StartRuleContext _context;

        public StartRuleNode(StartRuleContext context)
        {
            _ctx = _context = context;
        }

    }
}
