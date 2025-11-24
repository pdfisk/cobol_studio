namespace CobolStudio.src.parser.ast
{
    internal class ProgramUnitNode : AstNode
    {
        IdentificationDivisionNode _identificationDivision;
        EnvironmentDivisionNode _environmentDivision;
        DataDivisionNode _dataDivision;
        ProcedureDivisionNode _procedureDivision;

        public ProgramUnitNode(
            IdentificationDivisionNode identificationDivision,
            EnvironmentDivisionNode environmentDivision,
            DataDivisionNode dataDivision,
            ProcedureDivisionNode procedureDivision)
        {
            _identificationDivision = identificationDivision;
            _environmentDivision = environmentDivision;
            _dataDivision = dataDivision;
            _procedureDivision = procedureDivision;
        }
    }
}
