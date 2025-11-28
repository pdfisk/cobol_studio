using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class SentenceNode : AstNode
    {
        SentenceContext _context;

        public SentenceNode(SentenceContext context)
        {
            _ctx = _context = context;
        }

    }
}
