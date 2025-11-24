using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using CobolStudio.src.parser.ast;
using IronPython.Compiler.Ast;
using MyChatDB;
using System.Collections.Generic;
using static Cobol85Parser;

namespace CobolStudio.src.parser
{
    internal class Visitor : ICobol85Visitor<AstNode>
    {
        public Visitor()
        {
        }

        void PrintLn(string msg)
        {
            TranscriptWindow.GetInstance().PrintLn(msg);
        }

        public AstNode Visit(IParseTree tree)
        {
            PrintLn("Visiting: " + tree.GetType().Name);
            AstNode astNode = null;
            if (tree is CompilationUnitContext)
                astNode = VisitCompilationUnit(tree as CompilationUnitContext);
            else if (tree is StartRuleContext)
                astNode = VisitStartRule(tree as StartRuleContext);
            if (astNode == null)
            {
                PrintLn("No match visiting: " + tree.GetType().Name);
                return new AstNode();
            }
            else
                VisitChildren(astNode, tree);
            return astNode;
        }


        void VisitChildren(AstNode node, IParseTree tree)
        {
            var children = new List<AstNode>();
            for (int i = 0; i < tree.ChildCount; i++)
            {
                AstNode child = Visit(tree.GetChild(i));
                node.AddChild(child);
            }
        }

        public AstNode VisitAbbreviation([NotNull] AbbreviationContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAcceptFromDateStatement([NotNull] AcceptFromDateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAcceptFromEscapeKeyStatement([NotNull] AcceptFromEscapeKeyStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAcceptFromMnemonicStatement([NotNull] AcceptFromMnemonicStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAcceptMessageCountStatement([NotNull] AcceptMessageCountStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAcceptStatement([NotNull] AcceptStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAccessModeClause([NotNull] AccessModeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAddCorrespondingStatement([NotNull] AddCorrespondingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAddFrom([NotNull] AddFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAddGiving([NotNull] AddGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAddStatement([NotNull] AddStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAddTo([NotNull] AddToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAddToGiving([NotNull] AddToGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAddToGivingStatement([NotNull] AddToGivingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAddToStatement([NotNull] AddToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlphabetAlso([NotNull] AlphabetAlsoContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlphabetClause([NotNull] AlphabetClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlphabetClauseFormat1([NotNull] AlphabetClauseFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlphabetClauseFormat2([NotNull] AlphabetClauseFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlphabetLiterals([NotNull] AlphabetLiteralsContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlphabetName([NotNull] AlphabetNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlphabetThrough([NotNull] AlphabetThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlteredGoTo([NotNull] AlteredGoToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlternateRecordKeyClause([NotNull] AlternateRecordKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlterProceedTo([NotNull] AlterProceedToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAlterStatement([NotNull] AlterStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAndOrCondition([NotNull] AndOrConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitArgument([NotNull] ArgumentContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitArithmeticExpression([NotNull] ArithmeticExpressionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAssignClause([NotNull] AssignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAssignmentName([NotNull] AssignmentNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAtEndPhrase([NotNull] AtEndPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitAuthorParagraph([NotNull] AuthorParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitBasis([NotNull] BasisContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitBasisName([NotNull] BasisNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitBlockContainsClause([NotNull] BlockContainsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitBlockContainsTo([NotNull] BlockContainsToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitBooleanLiteral([NotNull] BooleanLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallByContent([NotNull] CallByContentContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallByContentPhrase([NotNull] CallByContentPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallByReference([NotNull] CallByReferenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallByReferencePhrase([NotNull] CallByReferencePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallByValue([NotNull] CallByValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallByValuePhrase([NotNull] CallByValuePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallGivingPhrase([NotNull] CallGivingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallStatement([NotNull] CallStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallUsingParameter([NotNull] CallUsingParameterContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCallUsingPhrase([NotNull] CallUsingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCancelCall([NotNull] CancelCallContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCancelStatement([NotNull] CancelStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCdName([NotNull] CdNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitChannelClause([NotNull] ChannelClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCharacterPosition([NotNull] CharacterPositionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCharacterSetClause([NotNull] CharacterSetClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitChildren(IRuleNode node)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCicsDfhRespLiteral([NotNull] CicsDfhRespLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCicsDfhValueLiteral([NotNull] CicsDfhValueLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClassClause([NotNull] ClassClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClassClauseFrom([NotNull] ClassClauseFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClassClauseThrough([NotNull] ClassClauseThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClassClauseTo([NotNull] ClassClauseToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClassCondition([NotNull] ClassConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClassName([NotNull] ClassNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCloseFile([NotNull] CloseFileContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClosePortFileIOStatement([NotNull] ClosePortFileIOStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClosePortFileIOUsing([NotNull] ClosePortFileIOUsingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClosePortFileIOUsingAssociatedData([NotNull] ClosePortFileIOUsingAssociatedDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClosePortFileIOUsingAssociatedDataLength([NotNull] ClosePortFileIOUsingAssociatedDataLengthContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitClosePortFileIOUsingCloseDisposition([NotNull] ClosePortFileIOUsingCloseDispositionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCloseReelUnitStatement([NotNull] CloseReelUnitStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCloseRelativeStatement([NotNull] CloseRelativeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCloseStatement([NotNull] CloseStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCobolWord([NotNull] CobolWordContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCodeSetClause([NotNull] CodeSetClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCollatingSequenceClause([NotNull] CollatingSequenceClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCollatingSequenceClauseAlphanumeric([NotNull] CollatingSequenceClauseAlphanumericContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCollatingSequenceClauseNational([NotNull] CollatingSequenceClauseNationalContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCombinableCondition([NotNull] CombinableConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCommentEntry([NotNull] CommentEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCommitmentControlClause([NotNull] CommitmentControlClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCommunicationDescriptionEntry([NotNull] CommunicationDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCommunicationDescriptionEntryFormat1([NotNull] CommunicationDescriptionEntryFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCommunicationDescriptionEntryFormat2([NotNull] CommunicationDescriptionEntryFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCommunicationDescriptionEntryFormat3([NotNull] CommunicationDescriptionEntryFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCommunicationSection([NotNull] CommunicationSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCompilationUnit([NotNull] CompilationUnitContext context)
        {
            return new CompilationUnitNode(context);
        }

        public AstNode VisitComputerName([NotNull] ComputerNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitComputeStatement([NotNull] ComputeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitComputeStore([NotNull] ComputeStoreContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCondition([NotNull] ConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitConditionName([NotNull] ConditionNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitConditionNameReference([NotNull] ConditionNameReferenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitConditionNameSubscriptReference([NotNull] ConditionNameSubscriptReferenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitConfigurationSection([NotNull] ConfigurationSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitConfigurationSectionParagraph([NotNull] ConfigurationSectionParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitContinueStatement([NotNull] ContinueStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitCurrencySignClause([NotNull] CurrencySignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataAlignedClause([NotNull] DataAlignedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataBaseSection([NotNull] DataBaseSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataBaseSectionEntry([NotNull] DataBaseSectionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataBlankWhenZeroClause([NotNull] DataBlankWhenZeroClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataCommonOwnLocalClause([NotNull] DataCommonOwnLocalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataDescName([NotNull] DataDescNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataDescriptionEntry([NotNull] DataDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataDescriptionEntryExecSql([NotNull] DataDescriptionEntryExecSqlContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataDescriptionEntryFormat1([NotNull] DataDescriptionEntryFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataDescriptionEntryFormat2([NotNull] DataDescriptionEntryFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataDescriptionEntryFormat3([NotNull] DataDescriptionEntryFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataDivision([NotNull] DataDivisionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataDivisionSection([NotNull] DataDivisionSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataExternalClause([NotNull] DataExternalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataGlobalClause([NotNull] DataGlobalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataIntegerStringClause([NotNull] DataIntegerStringClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataJustifiedClause([NotNull] DataJustifiedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataName([NotNull] DataNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataOccursClause([NotNull] DataOccursClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataOccursSort([NotNull] DataOccursSortContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataOccursTo([NotNull] DataOccursToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataPictureClause([NotNull] DataPictureClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataReceivedByClause([NotNull] DataReceivedByClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataRecordAreaClause([NotNull] DataRecordAreaClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataRecordsClause([NotNull] DataRecordsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataRedefinesClause([NotNull] DataRedefinesClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataRenamesClause([NotNull] DataRenamesClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataSignClause([NotNull] DataSignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataSynchronizedClause([NotNull] DataSynchronizedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataThreadLocalClause([NotNull] DataThreadLocalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataTypeClause([NotNull] DataTypeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataTypeDefClause([NotNull] DataTypeDefClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataUsageClause([NotNull] DataUsageClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataUsingClause([NotNull] DataUsingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataValueClause([NotNull] DataValueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataValueInterval([NotNull] DataValueIntervalContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataValueIntervalFrom([NotNull] DataValueIntervalFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataValueIntervalTo([NotNull] DataValueIntervalToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDataWithLowerBoundsClause([NotNull] DataWithLowerBoundsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDateCompiledParagraph([NotNull] DateCompiledParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDateWrittenParagraph([NotNull] DateWrittenParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDecimalPointClause([NotNull] DecimalPointClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDefaultComputationalSignClause([NotNull] DefaultComputationalSignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDefaultDisplaySignClause([NotNull] DefaultDisplaySignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDeleteStatement([NotNull] DeleteStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDestinationCountClause([NotNull] DestinationCountClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDestinationTableClause([NotNull] DestinationTableClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDisableStatement([NotNull] DisableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDiskSizeClause([NotNull] DiskSizeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDisplayAt([NotNull] DisplayAtContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDisplayOperand([NotNull] DisplayOperandContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDisplayStatement([NotNull] DisplayStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDisplayUpon([NotNull] DisplayUponContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDisplayWith([NotNull] DisplayWithContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDivideByGivingStatement([NotNull] DivideByGivingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDivideGiving([NotNull] DivideGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDivideGivingPhrase([NotNull] DivideGivingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDivideInto([NotNull] DivideIntoContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDivideIntoGivingStatement([NotNull] DivideIntoGivingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDivideIntoStatement([NotNull] DivideIntoStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDivideRemainder([NotNull] DivideRemainderContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitDivideStatement([NotNull] DivideStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEnableStatement([NotNull] EnableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEndKeyClause([NotNull] EndKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEndProgramStatement([NotNull] EndProgramStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEntryStatement([NotNull] EntryStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEnvironmentDivision([NotNull] EnvironmentDivisionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEnvironmentDivisionBody([NotNull] EnvironmentDivisionBodyContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEnvironmentName([NotNull] EnvironmentNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEnvironmentSwitchNameClause([NotNull] EnvironmentSwitchNameClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEnvironmentSwitchNameSpecialNamesStatusPhrase([NotNull] EnvironmentSwitchNameSpecialNamesStatusPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitErrorKeyClause([NotNull] ErrorKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitErrorNode(IErrorNode node)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateAlsoCondition([NotNull] EvaluateAlsoConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateAlsoSelect([NotNull] EvaluateAlsoSelectContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateCondition([NotNull] EvaluateConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateSelect([NotNull] EvaluateSelectContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateStatement([NotNull] EvaluateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateThrough([NotNull] EvaluateThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateValue([NotNull] EvaluateValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateWhen([NotNull] EvaluateWhenContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateWhenOther([NotNull] EvaluateWhenOtherContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitEvaluateWhenPhrase([NotNull] EvaluateWhenPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitExecCicsStatement([NotNull] ExecCicsStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitExecSqlImsStatement([NotNull] ExecSqlImsStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitExecSqlStatement([NotNull] ExecSqlStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitExhibitOperand([NotNull] ExhibitOperandContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitExhibitStatement([NotNull] ExhibitStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitExitStatement([NotNull] ExitStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitExternalClause([NotNull] ExternalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFigurativeConstant([NotNull] FigurativeConstantContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFileControlClause([NotNull] FileControlClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFileControlEntry([NotNull] FileControlEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFileControlParagraph([NotNull] FileControlParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFileDescriptionEntry([NotNull] FileDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFileDescriptionEntryClause([NotNull] FileDescriptionEntryClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFileName([NotNull] FileNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFileSection([NotNull] FileSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFileStatusClause([NotNull] FileStatusClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFunctionCall([NotNull] FunctionCallContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitFunctionName([NotNull] FunctionNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitGenerateStatement([NotNull] GenerateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitGlobalClause([NotNull] GlobalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitGobackStatement([NotNull] GobackStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitGoToDependingOnStatement([NotNull] GoToDependingOnStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitGoToStatement([NotNull] GoToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitGoToStatementSimple([NotNull] GoToStatementSimpleContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIdentificationDivision([NotNull] IdentificationDivisionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIdentificationDivisionBody([NotNull] IdentificationDivisionBodyContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIdentifier([NotNull] IdentifierContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIfElse([NotNull] IfElseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIfStatement([NotNull] IfStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIfThen([NotNull] IfThenContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInData([NotNull] InDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIndexName([NotNull] IndexNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInFile([NotNull] InFileContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInitializeReplacingBy([NotNull] InitializeReplacingByContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInitializeReplacingPhrase([NotNull] InitializeReplacingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInitializeStatement([NotNull] InitializeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInitiateStatement([NotNull] InitiateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInLibrary([NotNull] InLibraryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInMnemonic([NotNull] InMnemonicContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInputOutputSection([NotNull] InputOutputSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInputOutputSectionParagraph([NotNull] InputOutputSectionParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInSection([NotNull] InSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectAllLeading([NotNull] InspectAllLeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectAllLeadings([NotNull] InspectAllLeadingsContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectBeforeAfter([NotNull] InspectBeforeAfterContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectBy([NotNull] InspectByContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectCharacters([NotNull] InspectCharactersContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectConvertingPhrase([NotNull] InspectConvertingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectFor([NotNull] InspectForContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectReplacingAllLeading([NotNull] InspectReplacingAllLeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectReplacingAllLeadings([NotNull] InspectReplacingAllLeadingsContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectReplacingCharacters([NotNull] InspectReplacingCharactersContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectReplacingPhrase([NotNull] InspectReplacingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectStatement([NotNull] InspectStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectTallyingPhrase([NotNull] InspectTallyingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectTallyingReplacingPhrase([NotNull] InspectTallyingReplacingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInspectTo([NotNull] InspectToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInstallationParagraph([NotNull] InstallationParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInTable([NotNull] InTableContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIntegerLiteral([NotNull] IntegerLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitInvalidKeyPhrase([NotNull] InvalidKeyPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIoControlClause([NotNull] IoControlClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitIoControlParagraph([NotNull] IoControlParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLabelRecordsClause([NotNull] LabelRecordsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLanguageName([NotNull] LanguageNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLength([NotNull] LengthContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryAttributeClauseFormat1([NotNull] LibraryAttributeClauseFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryAttributeClauseFormat2([NotNull] LibraryAttributeClauseFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryAttributeFunction([NotNull] LibraryAttributeFunctionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryAttributeParameter([NotNull] LibraryAttributeParameterContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryAttributeTitle([NotNull] LibraryAttributeTitleContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryDescriptionEntry([NotNull] LibraryDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryDescriptionEntryFormat1([NotNull] LibraryDescriptionEntryFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryDescriptionEntryFormat2([NotNull] LibraryDescriptionEntryFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryEntryProcedureClauseFormat1([NotNull] LibraryEntryProcedureClauseFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryEntryProcedureClauseFormat2([NotNull] LibraryEntryProcedureClauseFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryEntryProcedureForClause([NotNull] LibraryEntryProcedureForClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryEntryProcedureGivingClause([NotNull] LibraryEntryProcedureGivingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryEntryProcedureUsingClause([NotNull] LibraryEntryProcedureUsingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryEntryProcedureUsingName([NotNull] LibraryEntryProcedureUsingNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryEntryProcedureWithClause([NotNull] LibraryEntryProcedureWithClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryEntryProcedureWithName([NotNull] LibraryEntryProcedureWithNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryIsCommonClause([NotNull] LibraryIsCommonClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryIsGlobalClause([NotNull] LibraryIsGlobalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLibraryName([NotNull] LibraryNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLinageAt([NotNull] LinageAtContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLinageClause([NotNull] LinageClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLinageFootingAt([NotNull] LinageFootingAtContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLinageLinesAtBottom([NotNull] LinageLinesAtBottomContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLinageLinesAtTop([NotNull] LinageLinesAtTopContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLinkageSection([NotNull] LinkageSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLiteral([NotNull] LiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLocalName([NotNull] LocalNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitLocalStorageSection([NotNull] LocalStorageSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMemorySizeClause([NotNull] MemorySizeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeCollatingAlphanumeric([NotNull] MergeCollatingAlphanumericContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeCollatingNational([NotNull] MergeCollatingNationalContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeCollatingSequencePhrase([NotNull] MergeCollatingSequencePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeGiving([NotNull] MergeGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeGivingPhrase([NotNull] MergeGivingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeOnKeyClause([NotNull] MergeOnKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeOutputProcedurePhrase([NotNull] MergeOutputProcedurePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeOutputThrough([NotNull] MergeOutputThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeStatement([NotNull] MergeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMergeUsing([NotNull] MergeUsingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMessageCountClause([NotNull] MessageCountClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMessageDateClause([NotNull] MessageDateClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMessageTimeClause([NotNull] MessageTimeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMnemonicName([NotNull] MnemonicNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitModeStatement([NotNull] ModeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMoveCorrespondingToSendingArea([NotNull] MoveCorrespondingToSendingAreaContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMoveCorrespondingToStatement([NotNull] MoveCorrespondingToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMoveStatement([NotNull] MoveStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMoveToSendingArea([NotNull] MoveToSendingAreaContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMoveToStatement([NotNull] MoveToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultDiv([NotNull] MultDivContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultDivs([NotNull] MultDivsContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultipleFileClause([NotNull] MultipleFileClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultipleFilePosition([NotNull] MultipleFilePositionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultiplyGiving([NotNull] MultiplyGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultiplyGivingOperand([NotNull] MultiplyGivingOperandContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultiplyGivingResult([NotNull] MultiplyGivingResultContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultiplyRegular([NotNull] MultiplyRegularContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultiplyRegularOperand([NotNull] MultiplyRegularOperandContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitMultiplyStatement([NotNull] MultiplyStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitNotAtEndPhrase([NotNull] NotAtEndPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitNotInvalidKeyPhrase([NotNull] NotInvalidKeyPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitNotOnExceptionClause([NotNull] NotOnExceptionClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitNotOnOverflowPhrase([NotNull] NotOnOverflowPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitNotOnSizeErrorPhrase([NotNull] NotOnSizeErrorPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitNumericLiteral([NotNull] NumericLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitObjectComputerClause([NotNull] ObjectComputerClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitObjectComputerParagraph([NotNull] ObjectComputerParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOdtClause([NotNull] OdtClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOnExceptionClause([NotNull] OnExceptionClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOnOverflowPhrase([NotNull] OnOverflowPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOnSizeErrorPhrase([NotNull] OnSizeErrorPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOpenExtendStatement([NotNull] OpenExtendStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOpenInput([NotNull] OpenInputContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOpenInputStatement([NotNull] OpenInputStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOpenIOStatement([NotNull] OpenIOStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOpenOutput([NotNull] OpenOutputContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOpenOutputStatement([NotNull] OpenOutputStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOpenStatement([NotNull] OpenStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitOrganizationClause([NotNull] OrganizationClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPaddingCharacterClause([NotNull] PaddingCharacterClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitParagraph([NotNull] ParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitParagraphName([NotNull] ParagraphNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitParagraphs([NotNull] ParagraphsContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPasswordClause([NotNull] PasswordClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformAfter([NotNull] PerformAfterContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformBy([NotNull] PerformByContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformFrom([NotNull] PerformFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformInlineStatement([NotNull] PerformInlineStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformProcedureStatement([NotNull] PerformProcedureStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformStatement([NotNull] PerformStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformTestClause([NotNull] PerformTestClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformTimes([NotNull] PerformTimesContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformType([NotNull] PerformTypeContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformUntil([NotNull] PerformUntilContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformVarying([NotNull] PerformVaryingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformVaryingClause([NotNull] PerformVaryingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPerformVaryingPhrase([NotNull] PerformVaryingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPictureCardinality([NotNull] PictureCardinalityContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPictureChars([NotNull] PictureCharsContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPictureString([NotNull] PictureStringContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPlusMinus([NotNull] PlusMinusContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPower([NotNull] PowerContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPowers([NotNull] PowersContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDeclarative([NotNull] ProcedureDeclarativeContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDeclaratives([NotNull] ProcedureDeclarativesContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDivision([NotNull] ProcedureDivisionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDivisionBody([NotNull] ProcedureDivisionBodyContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDivisionByReference([NotNull] ProcedureDivisionByReferenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDivisionByReferencePhrase([NotNull] ProcedureDivisionByReferencePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDivisionByValue([NotNull] ProcedureDivisionByValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDivisionByValuePhrase([NotNull] ProcedureDivisionByValuePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDivisionGivingClause([NotNull] ProcedureDivisionGivingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDivisionUsingClause([NotNull] ProcedureDivisionUsingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureDivisionUsingParameter([NotNull] ProcedureDivisionUsingParameterContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureName([NotNull] ProcedureNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureSection([NotNull] ProcedureSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProcedureSectionHeader([NotNull] ProcedureSectionHeaderContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProgramIdParagraph([NotNull] ProgramIdParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProgramLibrarySection([NotNull] ProgramLibrarySectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProgramName([NotNull] ProgramNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitProgramUnit([NotNull] ProgramUnitContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitPurgeStatement([NotNull] PurgeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitQualifiedDataName([NotNull] QualifiedDataNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitQualifiedDataNameFormat1([NotNull] QualifiedDataNameFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitQualifiedDataNameFormat2([NotNull] QualifiedDataNameFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitQualifiedDataNameFormat3([NotNull] QualifiedDataNameFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitQualifiedDataNameFormat4([NotNull] QualifiedDataNameFormat4Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitQualifiedInData([NotNull] QualifiedInDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReadInto([NotNull] ReadIntoContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReadKey([NotNull] ReadKeyContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReadStatement([NotNull] ReadStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReadWith([NotNull] ReadWithContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveBefore([NotNull] ReceiveBeforeContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveFrom([NotNull] ReceiveFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveFromStatement([NotNull] ReceiveFromStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveIntoStatement([NotNull] ReceiveIntoStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveNoData([NotNull] ReceiveNoDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveSize([NotNull] ReceiveSizeContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveStatement([NotNull] ReceiveStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveStatus([NotNull] ReceiveStatusContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveThread([NotNull] ReceiveThreadContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveWith([NotNull] ReceiveWithContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReceiveWithData([NotNull] ReceiveWithDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRecordContainsClause([NotNull] RecordContainsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRecordContainsClauseFormat1([NotNull] RecordContainsClauseFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRecordContainsClauseFormat2([NotNull] RecordContainsClauseFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRecordContainsClauseFormat3([NotNull] RecordContainsClauseFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRecordContainsTo([NotNull] RecordContainsToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRecordDelimiterClause([NotNull] RecordDelimiterClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRecordingModeClause([NotNull] RecordingModeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRecordKeyClause([NotNull] RecordKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRecordName([NotNull] RecordNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReferenceModifier([NotNull] ReferenceModifierContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRelationalOperator([NotNull] RelationalOperatorContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRelationArithmeticComparison([NotNull] RelationArithmeticComparisonContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRelationCombinedComparison([NotNull] RelationCombinedComparisonContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRelationCombinedCondition([NotNull] RelationCombinedConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRelationCondition([NotNull] RelationConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRelationSignCondition([NotNull] RelationSignConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRelativeKeyClause([NotNull] RelativeKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReleaseStatement([NotNull] ReleaseStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRemarksParagraph([NotNull] RemarksParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportClause([NotNull] ReportClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportDescription([NotNull] ReportDescriptionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportDescriptionEntry([NotNull] ReportDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportDescriptionFirstDetailClause([NotNull] ReportDescriptionFirstDetailClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportDescriptionFootingClause([NotNull] ReportDescriptionFootingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportDescriptionGlobalClause([NotNull] ReportDescriptionGlobalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportDescriptionHeadingClause([NotNull] ReportDescriptionHeadingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportDescriptionLastDetailClause([NotNull] ReportDescriptionLastDetailClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportDescriptionPageLimitClause([NotNull] ReportDescriptionPageLimitClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupBlankWhenZeroClause([NotNull] ReportGroupBlankWhenZeroClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupColumnNumberClause([NotNull] ReportGroupColumnNumberClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupDescriptionEntry([NotNull] ReportGroupDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupDescriptionEntryFormat1([NotNull] ReportGroupDescriptionEntryFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupDescriptionEntryFormat2([NotNull] ReportGroupDescriptionEntryFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupDescriptionEntryFormat3([NotNull] ReportGroupDescriptionEntryFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupIndicateClause([NotNull] ReportGroupIndicateClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupJustifiedClause([NotNull] ReportGroupJustifiedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupLineNumberClause([NotNull] ReportGroupLineNumberClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupLineNumberNextPage([NotNull] ReportGroupLineNumberNextPageContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupLineNumberPlus([NotNull] ReportGroupLineNumberPlusContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupNextGroupClause([NotNull] ReportGroupNextGroupClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupNextGroupNextPage([NotNull] ReportGroupNextGroupNextPageContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupNextGroupPlus([NotNull] ReportGroupNextGroupPlusContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupPictureClause([NotNull] ReportGroupPictureClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupResetClause([NotNull] ReportGroupResetClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupSignClause([NotNull] ReportGroupSignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupSourceClause([NotNull] ReportGroupSourceClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupSumClause([NotNull] ReportGroupSumClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupTypeClause([NotNull] ReportGroupTypeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupTypeControlFooting([NotNull] ReportGroupTypeControlFootingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupTypeControlHeading([NotNull] ReportGroupTypeControlHeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupTypeDetail([NotNull] ReportGroupTypeDetailContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupTypePageFooting([NotNull] ReportGroupTypePageFootingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupTypePageHeading([NotNull] ReportGroupTypePageHeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupTypeReportFooting([NotNull] ReportGroupTypeReportFootingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupTypeReportHeading([NotNull] ReportGroupTypeReportHeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupUsageClause([NotNull] ReportGroupUsageClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportGroupValueClause([NotNull] ReportGroupValueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportName([NotNull] ReportNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReportSection([NotNull] ReportSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRerunClause([NotNull] RerunClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRerunEveryClock([NotNull] RerunEveryClockContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRerunEveryOf([NotNull] RerunEveryOfContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRerunEveryRecords([NotNull] RerunEveryRecordsContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReserveClause([NotNull] ReserveClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReserveNetworkClause([NotNull] ReserveNetworkClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReturnInto([NotNull] ReturnIntoContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitReturnStatement([NotNull] ReturnStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRewriteFrom([NotNull] RewriteFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRewriteStatement([NotNull] RewriteStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitRoutineName([NotNull] RoutineNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSameClause([NotNull] SameClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionAutoClause([NotNull] ScreenDescriptionAutoClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionBackgroundColorClause([NotNull] ScreenDescriptionBackgroundColorClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionBellClause([NotNull] ScreenDescriptionBellClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionBlankClause([NotNull] ScreenDescriptionBlankClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionBlankWhenZeroClause([NotNull] ScreenDescriptionBlankWhenZeroClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionBlinkClause([NotNull] ScreenDescriptionBlinkClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionColumnClause([NotNull] ScreenDescriptionColumnClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionControlClause([NotNull] ScreenDescriptionControlClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionEntry([NotNull] ScreenDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionEraseClause([NotNull] ScreenDescriptionEraseClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionForegroundColorClause([NotNull] ScreenDescriptionForegroundColorClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionFromClause([NotNull] ScreenDescriptionFromClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionFullClause([NotNull] ScreenDescriptionFullClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionGridClause([NotNull] ScreenDescriptionGridClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionJustifiedClause([NotNull] ScreenDescriptionJustifiedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionLightClause([NotNull] ScreenDescriptionLightClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionLineClause([NotNull] ScreenDescriptionLineClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionPictureClause([NotNull] ScreenDescriptionPictureClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionPromptClause([NotNull] ScreenDescriptionPromptClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionPromptOccursClause([NotNull] ScreenDescriptionPromptOccursClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionRequiredClause([NotNull] ScreenDescriptionRequiredClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionReverseVideoClause([NotNull] ScreenDescriptionReverseVideoClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionSecureClause([NotNull] ScreenDescriptionSecureClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionSignClause([NotNull] ScreenDescriptionSignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionSizeClause([NotNull] ScreenDescriptionSizeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionToClause([NotNull] ScreenDescriptionToClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionUnderlineClause([NotNull] ScreenDescriptionUnderlineClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionUsageClause([NotNull] ScreenDescriptionUsageClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionUsingClause([NotNull] ScreenDescriptionUsingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionValueClause([NotNull] ScreenDescriptionValueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenDescriptionZeroFillClause([NotNull] ScreenDescriptionZeroFillClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenName([NotNull] ScreenNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitScreenSection([NotNull] ScreenSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSearchStatement([NotNull] SearchStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSearchVarying([NotNull] SearchVaryingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSearchWhen([NotNull] SearchWhenContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSectionName([NotNull] SectionNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSecurityParagraph([NotNull] SecurityParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSegmentLimitClause([NotNull] SegmentLimitClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSelectClause([NotNull] SelectClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendAdvancingLines([NotNull] SendAdvancingLinesContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendAdvancingMnemonic([NotNull] SendAdvancingMnemonicContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendAdvancingPage([NotNull] SendAdvancingPageContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendAdvancingPhrase([NotNull] SendAdvancingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendFromPhrase([NotNull] SendFromPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendReplacingPhrase([NotNull] SendReplacingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendStatement([NotNull] SendStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendStatementAsync([NotNull] SendStatementAsyncContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendStatementSync([NotNull] SendStatementSyncContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSendWithPhrase([NotNull] SendWithPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSentence([NotNull] SentenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSetByValue([NotNull] SetByValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSetStatement([NotNull] SetStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSetTo([NotNull] SetToContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSetToStatement([NotNull] SetToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSetToValue([NotNull] SetToValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSetUpDownByStatement([NotNull] SetUpDownByStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSimpleCondition([NotNull] SimpleConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortCollatingAlphanumeric([NotNull] SortCollatingAlphanumericContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortCollatingNational([NotNull] SortCollatingNationalContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortCollatingSequencePhrase([NotNull] SortCollatingSequencePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortDuplicatesPhrase([NotNull] SortDuplicatesPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortGiving([NotNull] SortGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortGivingPhrase([NotNull] SortGivingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortInputProcedurePhrase([NotNull] SortInputProcedurePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortInputThrough([NotNull] SortInputThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortOnKeyClause([NotNull] SortOnKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortOutputProcedurePhrase([NotNull] SortOutputProcedurePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortOutputThrough([NotNull] SortOutputThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortStatement([NotNull] SortStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSortUsing([NotNull] SortUsingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSourceComputerParagraph([NotNull] SourceComputerParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSpecialNameClause([NotNull] SpecialNameClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSpecialNamesParagraph([NotNull] SpecialNamesParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSpecialRegister([NotNull] SpecialRegisterContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStartKey([NotNull] StartKeyContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStartRule([NotNull] StartRuleContext context)
        {
            return new StartNode(context);
        }

        public AstNode VisitStartStatement([NotNull] StartStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStatement([NotNull] StatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStatusKeyClause([NotNull] StatusKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStopStatement([NotNull] StopStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStringDelimitedByPhrase([NotNull] StringDelimitedByPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStringForPhrase([NotNull] StringForPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStringIntoPhrase([NotNull] StringIntoPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStringSending([NotNull] StringSendingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStringSendingPhrase([NotNull] StringSendingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStringStatement([NotNull] StringStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitStringWithPointerPhrase([NotNull] StringWithPointerPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubscript_([NotNull] Subscript_Context context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubtractCorrespondingStatement([NotNull] SubtractCorrespondingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubtractFromGivingStatement([NotNull] SubtractFromGivingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubtractFromStatement([NotNull] SubtractFromStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubtractGiving([NotNull] SubtractGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubtractMinuend([NotNull] SubtractMinuendContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubtractMinuendCorresponding([NotNull] SubtractMinuendCorrespondingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubtractMinuendGiving([NotNull] SubtractMinuendGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubtractStatement([NotNull] SubtractStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSubtractSubtrahend([NotNull] SubtractSubtrahendContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSymbolicCharacter([NotNull] SymbolicCharacterContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSymbolicCharacters([NotNull] SymbolicCharactersContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSymbolicCharactersClause([NotNull] SymbolicCharactersClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSymbolicDestinationClause([NotNull] SymbolicDestinationClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSymbolicQueueClause([NotNull] SymbolicQueueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSymbolicSourceClause([NotNull] SymbolicSourceClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSymbolicSubQueueClause([NotNull] SymbolicSubQueueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSymbolicTerminalClause([NotNull] SymbolicTerminalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitSystemName([NotNull] SystemNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitTableCall([NotNull] TableCallContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitTerminal(ITerminalNode node)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitTerminateStatement([NotNull] TerminateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitTextLengthClause([NotNull] TextLengthClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitTextName([NotNull] TextNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringCountIn([NotNull] UnstringCountInContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringDelimitedByPhrase([NotNull] UnstringDelimitedByPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringDelimiterIn([NotNull] UnstringDelimiterInContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringInto([NotNull] UnstringIntoContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringIntoPhrase([NotNull] UnstringIntoPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringOrAllPhrase([NotNull] UnstringOrAllPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringSendingPhrase([NotNull] UnstringSendingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringStatement([NotNull] UnstringStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringTallyingPhrase([NotNull] UnstringTallyingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUnstringWithPointerPhrase([NotNull] UnstringWithPointerPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUseAfterClause([NotNull] UseAfterClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUseAfterOn([NotNull] UseAfterOnContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUseDebugClause([NotNull] UseDebugClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUseDebugOn([NotNull] UseDebugOnContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitUseStatement([NotNull] UseStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitValueOfClause([NotNull] ValueOfClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitValuePair([NotNull] ValuePairContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitWorkingStorageSection([NotNull] WorkingStorageSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitWriteAdvancingLines([NotNull] WriteAdvancingLinesContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitWriteAdvancingMnemonic([NotNull] WriteAdvancingMnemonicContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitWriteAdvancingPage([NotNull] WriteAdvancingPageContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitWriteAdvancingPhrase([NotNull] WriteAdvancingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitWriteAtEndOfPagePhrase([NotNull] WriteAtEndOfPagePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitWriteFromPhrase([NotNull] WriteFromPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitWriteNotAtEndOfPagePhrase([NotNull] WriteNotAtEndOfPagePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public AstNode VisitWriteStatement([NotNull] WriteStatementContext context)
        {
            throw new System.NotImplementedException();
        }

    }

}
