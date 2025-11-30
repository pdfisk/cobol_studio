using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.program;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class StartRuleNode : AstNode
    {
        StartRuleContext _context;
        ProgramModel _model;

        public StartRuleNode(StartRuleContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            _model = new ProgramModel(this);
            var literalNode = FindChildByType("LiteralNode");
            _model.SetName(literalNode == null ? "<unknown>" : literalNode._ctx.GetText());
            return _model;
        }


    }
}
