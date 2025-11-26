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
            programUnitNode = new ProgramUnitNode();
            return base.VisitStartRule(context);
        }

        public override object VisitDataDivision([NotNull] Cobol85Parser.DataDivisionContext context)
        {
            PrintLn($"Found DATA DIVISION at line {context.Start.Line}");
            programUnitNode.AddDataDivision(context);
            return base.VisitDataDivision(context);
        }
        public override object VisitIdentificationDivision([NotNull] Cobol85Parser.IdentificationDivisionContext context)
        {
            PrintLn($"Found IDENTIFICATION DIVISION at line {context.Start.Line}");
            programUnitNode.AddIdentificationDivision(context);
            return base.VisitIdentificationDivision(context);
        }

        public override object VisitEnvironmentDivision([NotNull] Cobol85Parser.EnvironmentDivisionContext context)
        {
            PrintLn($"Found ENVIRONMENT DIVISION at line {context.Start.Line}");
            programUnitNode.AddEnvironmentDivision(context);
            return base.VisitEnvironmentDivision(context);
        }

        public override object VisitProcedureDivision([NotNull] Cobol85Parser.ProcedureDivisionContext context)
        {
            PrintLn($"Found PROCEDURE DIVISION at line {context.Start.Line}");
            programUnitNode.AddProcedureDivision(context);
            return base.VisitProcedureDivision(context);
        }

        void PrintLn(string message)
        {
            TranscriptWindow.GetInstance().PrintLn(message);
        }
    }
}