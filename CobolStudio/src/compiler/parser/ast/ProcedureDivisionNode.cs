using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ProcedureDivisionNode : AstNode
    {
        ProcedureDivisionContext _context;

        public ProcedureDivisionNode(ProcedureDivisionContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new ProcedureDivisionModel(this);
        }


    }
}
