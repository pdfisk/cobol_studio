using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ProgramUnitNode : AstNode
    {
        ProgramUnitContext programUnitContext;

        public ProgramUnitNode(ProgramUnitContext programUnitContext)
        {
            this.programUnitContext = programUnitContext;
            _ctx = programUnitContext;
        }

    }
}
