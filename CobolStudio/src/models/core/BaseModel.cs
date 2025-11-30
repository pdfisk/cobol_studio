using CobolStudio.src.parser.ast;
using System.Collections.Generic;

namespace CobolStudio.src.models.core
{
    internal class BaseModel
    {
        AstNode _astNode;
        List<BaseModel> _children = new List<BaseModel>();


        public BaseModel(AstNode astNode)
        {
            _astNode = astNode;
        }

        public virtual void AddChild(BaseModel child)
        {
            _children.Add(child);
        }

        public override string ToString()
        {
            return $"Model: {GetType().Name} Children:  {_children.Count}";
        }
    }
}
