using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class LiteralNode : AstNode
    {
        LiteralContext _context;

        public LiteralNode(LiteralContext context)
        {
            _ctx = _context = context;
        }

    }
}
