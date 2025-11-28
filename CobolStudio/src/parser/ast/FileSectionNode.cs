using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class FileSectionNode : AstNode
    {
        FileSectionContext _context;

        public FileSectionNode(FileSectionContext context)
        {
            _ctx = _context = context;
        }

    }
}
