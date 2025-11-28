using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class StopStatementNode : AstNode
    {
        StopStatementContext _context;

        public StopStatementNode(StopStatementContext context)
        {
            _ctx = _context = context;
        }

    }
}
