using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class CobolWordNode : AstNode
    {
        CobolWordContext _context;

        public CobolWordNode(CobolWordContext context)
        {
            _ctx = _context = context;
        }

    }
}
