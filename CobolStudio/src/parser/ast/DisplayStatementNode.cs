using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class DisplayStatementNode : AstNode
    {
        DisplayStatementContext _context;

        public DisplayStatementNode(DisplayStatementContext context)
        {
            _ctx = _context = context;
        }

    }
}
