using CobolStudio.src.models.core;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.models.divisions
{
    public class CobolWordModel : BaseModel
    {
        string _word;

        public CobolWordModel(AstNode astNode, string word) : base(astNode)
        {
            _word = word;
        }

        internal override object AsSerializableObject()
        {
            return _word;
        }

        public override string ToString()
        {
            return _word;
        }

    }
}
