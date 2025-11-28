using Antlr4.Runtime;
using System.Collections.Generic;

namespace CobolStudio.src.parser.ast
{
    internal class AstNode
    {
        public List<AstNode> _children = new List<AstNode>();
        public RuleContext _ctx;
        public AstNode _parent;

        public void AddChild(AstNode child)
        {
            _children.Add(child);
            child._parent = this;
        }   

        public virtual string ToIndentedString(string indent = "")
        {
            string result = indent + ToString() + "\n";
            foreach (var child in _children)
            {
                result += child.ToIndentedString(indent + "  ");
            }
            return result;
        }

        public override string ToString()
        {
            return GetType().Name;
        }

        public string ToTreeString()
        {
            return ToIndentedString();
        }

        public string ToStringTree(CobolParser parser)
        {
            return _ctx.ToStringTree(parser);
        }
    }
}
