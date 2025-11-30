using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions.identification_division;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class ProgramNameNode : AstNode
    {
        ProgramNameContext _context;

        public ProgramNameNode(ProgramNameContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new ProgramIdNameModel(this);
        }

    }
}
