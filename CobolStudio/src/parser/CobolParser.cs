using Antlr4.Runtime;
using CobolStudio.src.parser.ast;

namespace CobolStudio.src.parser
{
    internal class CobolParser : Cobol85Parser
    {
        ITokenStream input_stream;

        public CobolParser(ITokenStream input_arg) : base(input_arg)
        {
            input_stream = input_arg;
        }

        public AstNode BuildAst()
        {
            var context = startRule();
            return BuildAst(context);
        }

        AstNode BuildAst(RuleContext context)
        {
            if (context == null)
                return null;
            if (context is ProgramUnitContext)
                return new ProgramUnitNode((ProgramUnitContext)context);
            return new ErrorNode(context, input_stream.Index.ToString());
        }
    }
}
