using CobolStudio.src.parser.ast;
using System.Collections.Generic;

namespace CobolStudio.src.models.core
{
    public class BaseModel
    {
        AstNode _astNode;
        List<BaseModel> _children = new List<BaseModel>();
        BaseModel _parent = null;


        public BaseModel(AstNode astNode)
        {
            _astNode = astNode;
        }

        internal virtual void AddChild(BaseModel child)
        {
            _children.Add(child);
            child._parent = this;
        }

        public override string ToString()
        {
            return $"Model: {GetType().Name} Children:  {_children.Count}";
        }
    }
}
