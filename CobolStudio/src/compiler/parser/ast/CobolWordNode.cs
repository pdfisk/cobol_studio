using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using CobolStudio.src.models.program;
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

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new CobolWordModel();
        }


    }
}
