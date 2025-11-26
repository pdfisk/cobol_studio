using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ProgramUnitNode : AstNode
    {
        IdentificationDivisionNode _identificationDivision;
        EnvironmentDivisionNode _environmentDivision;
        DataDivisionNode _dataDivision;
        ProcedureDivisionNode _procedureDivision;

        public ProgramUnitNode()
        {
        }

        public void AddDataDivision(DataDivisionContext context)
        {
            _dataDivision = new DataDivisionNode(context);
        }

        public void AddEnvironmentDivision(EnvironmentDivisionContext context)
        {
            _environmentDivision = new EnvironmentDivisionNode(context);
        }

        public void AddIdentificationDivision(IdentificationDivisionContext context)
        {
            _identificationDivision = new IdentificationDivisionNode(context);
        }

        public void AddProcedureDivision(ProcedureDivisionContext context)
        {
            _procedureDivision = new ProcedureDivisionNode(context);
        }

    }
}
