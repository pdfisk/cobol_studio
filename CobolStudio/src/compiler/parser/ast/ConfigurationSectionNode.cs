using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using CobolStudio.src.models.program;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class ConfigurationSectionNode : AstNode
    {
        ConfigurationSectionContext _context;

        public ConfigurationSectionNode(ConfigurationSectionContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            return new CompilationUnitModel();
        }

    }
}
