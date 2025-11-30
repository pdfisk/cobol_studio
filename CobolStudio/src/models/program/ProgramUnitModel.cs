using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.models
{
    public class ProgramUnitModel : BaseModel
    {
        public IdentificationDivisionModel identificationDivisionModel;
        public EnvironmentDivisionModel environmentDivisionModel;
        public DataDivisionSectionModel dataDivisionModel;
        public ProcedureDivisionModel procedureDivisionModel;

        public ProgramUnitModel(AstNode astNode) : base(astNode) { }

        public override void AddChild(BaseModel child)
        {
            base.AddChild(child);
            if (child is IdentificationDivisionModel)
            {
                identificationDivisionModel = (IdentificationDivisionModel)child;
            }
            else if (child is EnvironmentDivisionModel)
            {
                environmentDivisionModel = (EnvironmentDivisionModel)child;
            }
            else if (child is DataDivisionSectionModel)
            {
                dataDivisionModel = (DataDivisionSectionModel)child;
            }
            else if (child is ProcedureDivisionModel)
            {
                procedureDivisionModel = (ProcedureDivisionModel)child;
            }
        }

    }
}
