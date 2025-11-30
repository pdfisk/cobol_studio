using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class InputOutputSectionNode : AstNode
    {
        InputOutputSectionContext _context;

        public InputOutputSectionNode(InputOutputSectionContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new WorkingStorageSectionModel(this);
        }

    }
}
