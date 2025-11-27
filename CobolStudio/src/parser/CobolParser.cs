using Antlr4.Runtime;

namespace CobolStudio.src.parser
{
    internal class CobolParser : Cobol85Parser
    {
        public CobolParser(ITokenStream input) : base(input)
        {
        }
    }
}
