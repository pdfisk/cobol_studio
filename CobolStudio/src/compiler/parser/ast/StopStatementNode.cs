using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.program;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class StopStatementNode : AstNode
    {
        StopStatementContext _context;

        public StopStatementNode(StopStatementContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new StopStatementModel(this);
        }


    }
}
