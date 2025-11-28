using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ProcedureDivisionBodyNode : AstNode
    {
        ProcedureDivisionBodyContext _context;

        public ProcedureDivisionBodyNode(ProcedureDivisionBodyContext context)
        {
            _ctx = _context = context;
        }

    }
}
