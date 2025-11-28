using Antlr4.Runtime.Misc;
using CobolStudio.src.models;
using CobolStudio.src.parser.ast;
using MyChatDB;

namespace CobolStudio.src.parser
{
    internal class ProgramUnitVisitor : Cobol85BaseVisitor<object>
    {
        ProgramUnitNode programUnitNode;

        public override object VisitStartRule([NotNull] Cobol85Parser.StartRuleContext context)
        {
            PrintLn("Starting COBOL program analysis...");
            return base.VisitStartRule(context);
        }

        void PrintLn(string message)
        {
            TranscriptWindow.GetInstance().PrintLn(message);
        }

    }
}