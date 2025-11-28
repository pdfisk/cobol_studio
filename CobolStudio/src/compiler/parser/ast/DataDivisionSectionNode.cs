using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class DataDivisionSectionNode : AstNode
    {
        DataDivisionSectionContext _context;

        public DataDivisionSectionNode(DataDivisionSectionContext context)
        {
            _ctx = _context = context;
        }

    }
}
