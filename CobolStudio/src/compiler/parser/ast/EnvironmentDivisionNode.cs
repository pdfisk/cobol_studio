using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class EnvironmentDivisionNode : AstNode
    {
        EnvironmentDivisionContext _context;

        public EnvironmentDivisionNode(EnvironmentDivisionContext context)
        {
            _ctx = _context = context;
        }

    }
}
