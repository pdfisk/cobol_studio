using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class EndPrgramStatementNode : AstNode
    {
        EndProgramStatementContext _context;

        public EndPrgramStatementNode(EndProgramStatementContext context)
        {
            _ctx = _context = context;
        }

    }
}
