using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class DisplayOperandNode : AstNode
    {
        DisplayOperandContext _context;

        public DisplayOperandNode(DisplayOperandContext context)
        {
            _ctx = _context = context;
        }

    }
}
