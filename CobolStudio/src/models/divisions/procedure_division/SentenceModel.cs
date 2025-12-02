using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using CobolStudio.src.models.divisions.identification_division;
using CobolStudio.src.parser.ast;
using System.IO;

namespace CobolStudio.src.models.program
{

    public class SentenceModel : BaseModel
    {
        // ============================
        // expose for Python interop
        // ============================

        public string describe()
        {
            var sw = new StringWriter();
            var statements = get_statements();
            foreach (var stmt in (object[])statements)
            {
                sw.WriteLine(((StatementModel)stmt).describe().TrimEnd());
            }
            return sw.ToString().TrimEnd();
        }


        public object get_statements()
        {
            return FindChildrenByType(typeof(StatementModel));
        }

        // ============================

        public SentenceModel(AstNode astNode) : base(astNode)
        {
        }

    }

}
