using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions.identification_division;
using CobolStudio.src.models.program;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.models.divisions
{
    public class ProcedureDivisionModel : BaseModel
    {
        // ============================
        // expose for Python interop
        // ============================

        public object get_paragraphs()
        {
            return FindChildrenByType(typeof(ParagraphsModel));
        }

        // ============================

        public ProcedureDivisionModel(AstNode astNode) : base(astNode)
        {
        }
    }
}
