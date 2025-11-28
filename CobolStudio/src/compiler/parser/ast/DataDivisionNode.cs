using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class DataDivisionNode : AstNode
    {
        DataDivisionContext _context;

        public DataDivisionNode(DataDivisionContext context)
        {
            _ctx = _context = context;
        }

    }
}
