using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using CobolStudio.src.models.divisions.identification_division;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.models.program
{

    public class SentenceModel : BaseModel
    {
        // ============================
        // expose for Python interop
        // ============================

        public object get_statements()
        {
            return FindChildrenByType(typeof(StatementModel));
        }

        // ============================

        public SentenceModel(AstNode astNode) : base(astNode)
        {
        }

    }

}
