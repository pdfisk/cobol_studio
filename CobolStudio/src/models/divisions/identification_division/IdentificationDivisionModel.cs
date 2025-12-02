using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions.identification_division;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.models.divisions
{
    public class IdentificationDivisionModel : BaseModel
    {

        // ============================
        // expose for Python interop
        // ============================

        public object get_program_name()
        {
            //return FindChildByType(typeof(ProgramIdNameModel)).FindChildByType(typeof(CobolWordModel)).ToString();
            return FindChildByTypes(typeof(ProgramIdNameModel), typeof(CobolWordModel)).ToString();
        }

        // ============================

        public IdentificationDivisionModel(AstNode astNode) : base(astNode)
        {
        }

    }
}
