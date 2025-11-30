using CobolStudio.src.models.core;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.models.program
{
    public class ProgramModel : BaseModel
    {
        string _name = "<unknown>";

        public ProgramModel(AstNode astNode) : base(astNode)
        {
        }

        public string GetName()
        {
            return _name;
        }

        internal void SetName(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"ProgramModel: {_name}";
        }

    }
}
