using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions.identification_division;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ProgramIdParagraphNode : AstNode
    {
        ProgramIdParagraphContext _context;

        public ProgramIdParagraphNode(ProgramIdParagraphContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new ProgramIdParagraphModel(this);
        }


    }
}
