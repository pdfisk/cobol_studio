using Antlr4.Runtime.Tree;
using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using Microsoft.Scripting.Utils;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class CobolWordNode : AstNode
    {
        CobolWordContext _context;

        public CobolWordNode(CobolWordContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            var terminalNode = _context.GetChild<ITerminalNode>(0);
            string word = terminalNode.GetText();
            return new CobolWordModel(this, word);
        }


    }
}
