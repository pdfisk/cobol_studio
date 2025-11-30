using CobolStudio.src.models.core;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.models.program
{
    public class ProgramModel : BaseModel
    {
        public ProgramModel(AstNode astNode) : base(astNode)
        {
        }

        public string GetName()
        {
            return "PROGRAM_NAME";
        }
    }
}
