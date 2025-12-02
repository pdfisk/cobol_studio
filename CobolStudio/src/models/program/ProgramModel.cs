using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.models.program
{
    public class ProgramModel : BaseModel
    {
        // ============================
        // expose for Python interop
        // ============================

        public object get_data_division()
        {
            return FindChildByType(typeof(DataDivisionModel));
        }

        public object get_environment_division()
        {
            return FindChildByType(typeof(EnvironmentDivisionModel));
        }

        public object get_identification_division()
        {
            return FindChildByType(typeof(IdentificationDivisionModel));
        }

        public object get_procedure_division()
        {
            return FindChildByType(typeof(ProcedureDivisionModel));
        }

        // ============================

        public ProgramModel(AstNode astNode) : base(astNode)
        {
        }

    }
}
