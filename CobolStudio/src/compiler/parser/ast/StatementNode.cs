using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class StatementNode : AstNode
    {
        StatementContext _context;

        public StatementNode(StatementContext context)
        {
            _ctx = _context = context;
        }

    }
}
