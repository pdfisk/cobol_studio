using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ProgramUnitNode : AstNode
    {
        ProgramUnitContext _context;

        public ProgramUnitNode(ProgramUnitContext context)
        {
            _ctx = _context = context;
        }

    }
}
