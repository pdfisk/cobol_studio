using Antlr4.Runtime;
using System.Collections.Generic;

namespace CobolStudio.src.parser.ast
{
    internal class AstNode
    {
        public List<AstNode> children = new List<AstNode>();
        public RuleContext _ctx;

        public void AddChild(AstNode child)
        {
            children.Add(child);
        }   

        public override string ToString()
        {
            return GetType().Name;
        }

        public virtual string ToDetailedString(string indent = "")
        {
            string result = indent + ToString() + "\n";
            foreach (var child in children)
            {
                result += child.ToDetailedString(indent + "  ");
            }
            return result;
        }

        public string ToTreeString()
        {
            return ToDetailedString();
        }

        public string ToStringTree(CobolParser parser)
        {
            return _ctx.ToStringTree(parser);
        }
    }
}
