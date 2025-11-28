using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class EnvironmentDivisionBodyNode : AstNode
    {
        EnvironmentDivisionBodyContext _context;

        public EnvironmentDivisionBodyNode(EnvironmentDivisionBodyContext context)
        {
            _ctx = _context = context;
        }

    }
}
