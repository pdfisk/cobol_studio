using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ParagraphsNode : AstNode
    {
        ParagraphsContext _context;

        public ParagraphsNode(ParagraphsContext context)
        {
            _ctx = _context = context;
        }

    }
}
