using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ProcedureDivisionNode : AstNode
    {
        ProcedureDivisionContext _context;

        public ProcedureDivisionNode(ProcedureDivisionContext context)
        {
            _ctx = _context = context;
        }

    }
}
