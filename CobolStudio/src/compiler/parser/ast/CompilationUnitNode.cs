using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class CompilationUnitNode : AstNode
    {
        CompilationUnitContext _context;

        public CompilationUnitNode(CompilationUnitContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel Generate(CompilerUtil compilerUtil)
        {
            return FirstChild().Generate(compilerUtil);
        }

    }
}
