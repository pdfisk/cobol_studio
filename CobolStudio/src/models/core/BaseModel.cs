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

        public string AsJson()
        {
            var serializableObject = AsSerializableObject();
            return Newtonsoft.Json.JsonConvert.SerializeObject(serializableObject, Newtonsoft.Json.Formatting.Indented);
        }

        internal virtual object AsSerializableObject()
        {
            var dict = new Dictionary<string, object>();
            dict["type"] = GetType().Name;
            var childrenList = new List<object>();
            foreach (var child in _children)
            {
                childrenList.Add(child.AsSerializableObject());
            }
            dict["children"] = childrenList;
            return dict;
        }

        internal int ChildCount()
        {
            return _children.Count;
        }

        internal int CountWithAllChildren()
        {
            int count = 1;
            foreach (var child in _children)
            {
                count += child.CountWithAllChildren();
            }
            return count;
        }

        public override string ToString()
        {
            return $"Model: {GetType().Name} Children:  {_children.Count}";
        }
    }
}
