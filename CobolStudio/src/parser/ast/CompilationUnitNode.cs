using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class CompilationUnitNode:AstNode
    {
        CompilationUnitContext _context;

        public CompilationUnitNode(CompilationUnitContext context)
        {
            _ctx = _context = context;
        }

    }
}
