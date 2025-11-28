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

    }
}
