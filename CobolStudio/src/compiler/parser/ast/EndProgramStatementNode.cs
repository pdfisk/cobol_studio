using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class EndPrgramStatementNode : AstNode
    {
        EndProgramStatementContext _context;

        public EndPrgramStatementNode(EndProgramStatementContext context)
        {
            _ctx = _context = context;
        }

    }
}
