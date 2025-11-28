using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ProgramNameNode : AstNode
    {
        ProgramNameContext _context;

        public ProgramNameNode(ProgramNameContext context)
        {
            _ctx = _context = context;
        }

    }
}
