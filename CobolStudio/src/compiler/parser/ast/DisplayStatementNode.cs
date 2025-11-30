using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using CobolStudio.src.models.program;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class DisplayStatementNode : AstNode
    {
        DisplayStatementContext _context;

        public DisplayStatementNode(DisplayStatementContext context)
        {
            _ctx = _context = context;
        }


        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new DisplayStatementModel(this);
        }



    }
}
