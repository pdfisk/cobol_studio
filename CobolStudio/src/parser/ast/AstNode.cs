using Antlr4.Runtime;

namespace CobolStudio.src.parser.ast
{
    internal class AstNode
    {
       public RuleContext ctx;

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
