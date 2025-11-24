using Antlr4.Runtime.Misc;
using MyChatDB;
using System;

namespace CobolStudio.src.parser
{
    internal class Visitor : Cobol85BaseVisitor<object>
    {
        public override object VisitStartRule([NotNull] Cobol85Parser.StartRuleContext context)
        {
            PrintLn("Starting COBOL program analysis...");
            return base.VisitStartRule(context);
        }

        public override object VisitProcedureDivision([NotNull] Cobol85Parser.ProcedureDivisionContext context)
        {
            PrintLn($"Found PROCEDURE DIVISION at line {context.Start.Line}");
            return base.VisitProcedureDivision(context);
        }

        void PrintLn(string message)
        {
            TranscriptWindow.GetInstance().PrintLn(message);
        }
    }
}