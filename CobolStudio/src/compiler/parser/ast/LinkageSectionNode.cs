using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class LinkageSectionNode : AstNode
    {
        LinkageSectionContext _context;

        public LinkageSectionNode(LinkageSectionContext context)
        {
            _ctx = _context = context;
        }

    }
}
