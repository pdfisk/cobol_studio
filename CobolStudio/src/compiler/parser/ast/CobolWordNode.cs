using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class CobolWordNode : AstNode
    {
        CobolWordContext _context;

        public CobolWordNode(CobolWordContext context)
        {
            _ctx = _context = context;
        }

        internal object AsSerializableObject()
        {
            return _context.GetText();
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new CobolWordModel(this);
        }


    }
}
