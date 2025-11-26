using CobolStudio.src.models.divisions;

namespace CobolStudio.src.models
{
    internal class ProgramModel
    {
        public IdentificationDivisionModel identificationDivisionModel;
        public EnvironmentDivisionModel environmentDivisionModel;
        public DataDivisionModel dataDivisionModel;
        public ProcedureDivisionModel procedureDivisionModel;

        public ProgramModel()
        {
            identificationDivisionModel = new IdentificationDivisionModel();
            environmentDivisionModel = new EnvironmentDivisionModel();
            dataDivisionModel = new DataDivisionModel();
            procedureDivisionModel = new ProcedureDivisionModel();
        }

    }
}
