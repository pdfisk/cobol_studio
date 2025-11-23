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
    }
}
