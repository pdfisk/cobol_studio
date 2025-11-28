using Antlr4.Runtime;
using CobolStudio.src.parser.ast;
using MyChatDB;
using static Cobol85Parser;
using static IronPython.Modules._ast;

namespace CobolStudio.src.parser
{
    internal class CobolParser : Cobol85Parser
    {
        ITokenStream input_stream;

        public CobolParser(ITokenStream input_arg) : base(input_arg)
        {
            input_stream = input_arg;
        }

        public AstNode BuildAst()
        {
            var context = startRule();
            return BuildAst(context);
        }

        AstNode BuildAst(RuleContext context)
        {
            AstNode node = null;
            if (context == null)
                return null;

            var contextName = context.GetType().ToString();

            // start
            if (context is CompilationUnitContext)
                node = new CompilationUnitNode((CompilationUnitContext)context);
            else if (context is StartRuleContext)
                node = new StartRuleNode((StartRuleContext)context);
            else if (context is ProgramUnitContext)
                node = new ProgramUnitNode((ProgramUnitContext)context);

            // identification division
            else if (context is IdentificationDivisionContext)
                node = new IdentificationDivisionNode((IdentificationDivisionContext)context);
            else if (context is ProgramIdParagraphContext)
                node = new ProgramIdParagraphNode((ProgramIdParagraphContext)context);
            else if (context is ProgramNameContext)
                node = new ProgramNameNode((ProgramNameContext)context);

            // environment division
            else if (context is EnvironmentDivisionContext)
                node = new EnvironmentDivisionNode((EnvironmentDivisionContext)context);
            else if (context is EnvironmentDivisionBodyContext)
                node = new EnvironmentDivisionBodyNode((EnvironmentDivisionBodyContext)context);
            else if (context is CobolWordContext)
                node = new CobolWordNode((CobolWordContext)context);
            else if (context is ConfigurationSectionContext)
                node = new ConfigurationSectionNode((ConfigurationSectionContext)context);
            else if (context is FileSectionContext)
                node = new FileSectionNode((FileSectionContext)context);
            else if (context is InputOutputSectionContext)
                node = new InputOutputSectionNode((InputOutputSectionContext)context);
            else if (context is LinkageSectionContext)
                node = new LinkageSectionNode((LinkageSectionContext)context);

            // data division
            else if (context is DataDivisionContext)
                node = new DataDivisionNode((DataDivisionContext)context);
            else if (context is DataDivisionSectionContext)
                node = new DataDivisionSectionNode((DataDivisionSectionContext)context);
            else if (context is WorkingStorageSectionContext)
                node = new WorkingStorageSectionNode((WorkingStorageSectionContext)context);

            // procedure division
            else if (context is ProcedureDivisionContext)
                node = new ProcedureDivisionNode((ProcedureDivisionContext)context);
            else if (context is ProcedureDivisionBodyContext)
                node = new ProcedureDivisionBodyNode((ProcedureDivisionBodyContext)context);
            else if (context is DisplayOperandContext)
                node = new DisplayOperandNode((DisplayOperandContext)context);
            else if (context is DisplayStatementContext)
                node = new DisplayStatementNode((DisplayStatementContext)context);
            else if (context is EndProgramStatementContext)
                node = new EndPrgramStatementNode((EndProgramStatementContext)context);
            else if (context is LiteralContext)
                node = new LiteralNode((LiteralContext)context);
            else if (context is ParagraphsContext)
                node = new ParagraphsNode((ParagraphsContext)context);
            else if (context is SentenceContext)
                node = new SentenceNode((SentenceContext)context);
            else if (context is StatementContext)
                node = new StatementNode((StatementContext)context);
            else if (context is StopStatementContext)
                node = new StopStatementNode((StopStatementContext)context);

            // child nodes
            if (node != null)
            {
                for (var i = 0; i < context.ChildCount; i++)
                {
                    var child = context.GetChild(i);
                    if (child is RuleContext)
                    {
                        var childNode = BuildAst((RuleContext)child);
                        if (childNode != null)
                            node.AddChild(childNode);
                    }
                }
                return node;
            }

            // error node
            var message = $"[AST] Unhandled context type: {contextName}";
            PrintLn(message);
            return new ErrorNode(context, message);
        }

        void PrintLn(string message)
        {
            TranscriptWindow.GetInstance().PrintLn(message);
        }
    }
}
