using CobolStudio.src.compiler.core;
using CobolStudio.src.models;
using CobolStudio.src.models.core;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class ProgramUnitNode : AstNode
    {
        ProgramUnitContext _context;

        public ProgramUnitNode(ProgramUnitContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new ProgramUnitModel(this);
        }

    }
}
