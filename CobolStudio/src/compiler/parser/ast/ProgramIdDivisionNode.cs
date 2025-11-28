using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ProgramIdParagraphNode : AstNode
    {
        ProgramIdParagraphContext _context;

        public ProgramIdParagraphNode(ProgramIdParagraphContext context)
        {
            _ctx = _context = context;
        }

    }
}
