using CobolStudio.src.models.core;
using CobolStudio.src.models.program;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.models.divisions
{
    public class ParagraphsModel : BaseModel
    {
        // ============================
        // expose for Python interop
        // ============================

        public object get_sentences()
        {
            return FindChildrenByType(typeof(SentenceModel));
        }

        // ============================

        public ParagraphsModel(AstNode astNode) : base(astNode)
        {
        }
    }
}
