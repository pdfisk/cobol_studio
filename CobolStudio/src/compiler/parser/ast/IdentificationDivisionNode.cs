using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class IdentificationDivisionNode : AstNode
    {
        IdentificationDivisionContext _context;

        public IdentificationDivisionNode(IdentificationDivisionContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new CobolWordModel(this);
        }


    }
}
