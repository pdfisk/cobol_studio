using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.program;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class DisplayOperandNode : AstNode
    {
        DisplayOperandContext _context;

        public DisplayOperandNode(DisplayOperandContext context)
        {
            _ctx = _context = context;
        }
        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new DisplayOperandModel(this);
        }

    }
}
