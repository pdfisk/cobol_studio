using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;

namespace CobolStudio.src.models
{
    internal class ProgramUnitModel : BaseModel
    {
        public IdentificationDivisionModel identificationDivisionModel;
        public EnvironmentDivisionModel environmentDivisionModel;
        public DataDivisionModel dataDivisionModel;
        public ProcedureDivisionModel procedureDivisionModel;

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
            else if (child is DataDivisionModel)
            {
                dataDivisionModel = (DataDivisionModel)child;
            }
            else if (child is ProcedureDivisionModel)
            {
                procedureDivisionModel = (ProcedureDivisionModel)child;
            }
        }

    }
}
