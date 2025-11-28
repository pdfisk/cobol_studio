using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class IdentificationDivisionNode : AstNode
    {
        IdentificationDivisionContext _context;

        public IdentificationDivisionNode(IdentificationDivisionContext context)
        {
            _ctx = _context = context;
        }

    }
}
