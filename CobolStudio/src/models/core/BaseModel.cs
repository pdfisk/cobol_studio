using CobolStudio.src.models.divisions;
using CobolStudio.src.parser.ast;
using System;
using System.Collections.Generic;
using System.IO;

namespace CobolStudio.src.models.core
{
    public class BaseModel
    {
        AstNode _astNode;
        List<BaseModel> _children = new List<BaseModel>();
        BaseModel _parent = null;

        // ============================
        // expose for Python interop
        // ============================

        public string as_json()
        {
            var serializableObject = AsSerializableObject();
            return Newtonsoft.Json.JsonConvert.SerializeObject(serializableObject, Newtonsoft.Json.Formatting.Indented);
        }

        public string to_string_tree()
        {
            var sw = new StringWriter();
            WriteStringTree(sw, 0);
            return sw.ToString();
        }

        // ============================


        public BaseModel(AstNode astNode)
        {
            _astNode = astNode;
        }

        internal virtual void AddChild(BaseModel child)
        {
            _children.Add(child);
            child._parent = this;
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

        internal BaseModel FindChildByType(Type aType)
        {
            if (GetType() == aType)
                return this;
            foreach (var child in _children)
            {
                var result = child.FindChildByType(aType);
                if (result != null)
                    return result;
            }
            return null;
        }

        internal BaseModel FindChildByTypes(params Type[] types)
        {
            BaseModel result = this;
            for (int i = 0; i < types.Length; i++)
            {
                result = result.FindChildByType(types[i]);
                if (result == null)
                    break;
            }
            return result;
        }

        void WriteStringTree(StringWriter sw, int indent)
        {
            for (int i = 0; i < indent; i++)
                sw.Write("  ");
            sw.WriteLine(GetType().Name);
            foreach (var child in _children)
                child.WriteStringTree(sw, indent + 1);
        }
    }
}
