using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class ParagraphsNode : AstNode
    {
        ParagraphsContext _context;

        public ParagraphsNode(ParagraphsContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new ParagraphsModel(this);
        }

    }
}
