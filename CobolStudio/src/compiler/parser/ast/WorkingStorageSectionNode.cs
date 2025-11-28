using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    internal class WorkingStorageSectionNode : AstNode
    {
        WorkingStorageSectionContext _context;

        public WorkingStorageSectionNode(WorkingStorageSectionContext context)
        {
            _ctx = _context = context;
        }

    }
}
