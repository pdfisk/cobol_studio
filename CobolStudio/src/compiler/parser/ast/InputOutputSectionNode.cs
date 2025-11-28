using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class InputOutputSectionNode : AstNode
    {
        InputOutputSectionContext _context;

        public InputOutputSectionNode(InputOutputSectionContext context)
        {
            _ctx = _context = context;
        }

    }
}
