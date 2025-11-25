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

        public override object VisitDataDivision([NotNull] Cobol85Parser.DataDivisionContext context)
        {
            PrintLn($"Found DATA DIVISION at line {context.Start.Line}");
            return base.VisitDataDivision(context);
        }
        public override object VisitIdentificationDivision([NotNull] Cobol85Parser.IdentificationDivisionContext context)
        {
            PrintLn($"Found IDENTIFICATION DIVISION at line {context.Start.Line}");
            return base.VisitIdentificationDivision(context);
        }

        public override object VisitEnvironmentDivision([NotNull] Cobol85Parser.EnvironmentDivisionContext context)
        {
            PrintLn($"Found ENVIRONMENT DIVISION at line {context.Start.Line}");
            return base.VisitEnvironmentDivision(context);
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