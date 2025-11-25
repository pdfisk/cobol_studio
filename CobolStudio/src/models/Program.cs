using CobolStudio.src.models.divisions;

namespace CobolStudio.src.models
{
    internal class Program
    {
        IdentificationDivision identificationDivision;
        EnvironmentDivision environmentDivision;
        DataDivision dataDivision;
        ProcedureDivision procedureDivision;

        public Program()
        {
            identificationDivision = new IdentificationDivision();
            environmentDivision = new EnvironmentDivision();
            dataDivision = new DataDivision();
            procedureDivision = new ProcedureDivision();
        }

    }
}
