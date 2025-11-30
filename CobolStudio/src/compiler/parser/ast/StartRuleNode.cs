using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.program;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class StartRuleNode : AstNode
    {
        StartRuleContext _context;

        public StartRuleNode(StartRuleContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new ProgramModel(this);
        }


    }
}
