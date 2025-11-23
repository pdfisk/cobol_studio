using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
namespace CobolStudio.src.parser
{
    internal class Visitor : ICobol85Visitor<object>
    {
        public Visitor()
        {
        }

        public object Visit(IParseTree tree)
        {
            return VisitStartRule(tree as Cobol85Parser.StartRuleContext);
        }

        public object VisitAbbreviation([NotNull] Cobol85Parser.AbbreviationContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAcceptFromDateStatement([NotNull] Cobol85Parser.AcceptFromDateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAcceptFromEscapeKeyStatement([NotNull] Cobol85Parser.AcceptFromEscapeKeyStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAcceptFromMnemonicStatement([NotNull] Cobol85Parser.AcceptFromMnemonicStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAcceptMessageCountStatement([NotNull] Cobol85Parser.AcceptMessageCountStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAcceptStatement([NotNull] Cobol85Parser.AcceptStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAccessModeClause([NotNull] Cobol85Parser.AccessModeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAddCorrespondingStatement([NotNull] Cobol85Parser.AddCorrespondingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAddFrom([NotNull] Cobol85Parser.AddFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAddGiving([NotNull] Cobol85Parser.AddGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAddStatement([NotNull] Cobol85Parser.AddStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAddTo([NotNull] Cobol85Parser.AddToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAddToGiving([NotNull] Cobol85Parser.AddToGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAddToGivingStatement([NotNull] Cobol85Parser.AddToGivingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAddToStatement([NotNull] Cobol85Parser.AddToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlphabetAlso([NotNull] Cobol85Parser.AlphabetAlsoContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlphabetClause([NotNull] Cobol85Parser.AlphabetClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlphabetClauseFormat1([NotNull] Cobol85Parser.AlphabetClauseFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlphabetClauseFormat2([NotNull] Cobol85Parser.AlphabetClauseFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlphabetLiterals([NotNull] Cobol85Parser.AlphabetLiteralsContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlphabetName([NotNull] Cobol85Parser.AlphabetNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlphabetThrough([NotNull] Cobol85Parser.AlphabetThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlteredGoTo([NotNull] Cobol85Parser.AlteredGoToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlternateRecordKeyClause([NotNull] Cobol85Parser.AlternateRecordKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlterProceedTo([NotNull] Cobol85Parser.AlterProceedToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAlterStatement([NotNull] Cobol85Parser.AlterStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAndOrCondition([NotNull] Cobol85Parser.AndOrConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitArgument([NotNull] Cobol85Parser.ArgumentContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitArithmeticExpression([NotNull] Cobol85Parser.ArithmeticExpressionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAssignClause([NotNull] Cobol85Parser.AssignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAssignmentName([NotNull] Cobol85Parser.AssignmentNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAtEndPhrase([NotNull] Cobol85Parser.AtEndPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitAuthorParagraph([NotNull] Cobol85Parser.AuthorParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitBasis([NotNull] Cobol85Parser.BasisContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitBasisName([NotNull] Cobol85Parser.BasisNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitBlockContainsClause([NotNull] Cobol85Parser.BlockContainsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitBlockContainsTo([NotNull] Cobol85Parser.BlockContainsToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitBooleanLiteral([NotNull] Cobol85Parser.BooleanLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallByContent([NotNull] Cobol85Parser.CallByContentContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallByContentPhrase([NotNull] Cobol85Parser.CallByContentPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallByReference([NotNull] Cobol85Parser.CallByReferenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallByReferencePhrase([NotNull] Cobol85Parser.CallByReferencePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallByValue([NotNull] Cobol85Parser.CallByValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallByValuePhrase([NotNull] Cobol85Parser.CallByValuePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallGivingPhrase([NotNull] Cobol85Parser.CallGivingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallStatement([NotNull] Cobol85Parser.CallStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallUsingParameter([NotNull] Cobol85Parser.CallUsingParameterContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCallUsingPhrase([NotNull] Cobol85Parser.CallUsingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCancelCall([NotNull] Cobol85Parser.CancelCallContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCancelStatement([NotNull] Cobol85Parser.CancelStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCdName([NotNull] Cobol85Parser.CdNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitChannelClause([NotNull] Cobol85Parser.ChannelClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCharacterPosition([NotNull] Cobol85Parser.CharacterPositionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCharacterSetClause([NotNull] Cobol85Parser.CharacterSetClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitChildren(IRuleNode node)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCicsDfhRespLiteral([NotNull] Cobol85Parser.CicsDfhRespLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCicsDfhValueLiteral([NotNull] Cobol85Parser.CicsDfhValueLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClassClause([NotNull] Cobol85Parser.ClassClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClassClauseFrom([NotNull] Cobol85Parser.ClassClauseFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClassClauseThrough([NotNull] Cobol85Parser.ClassClauseThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClassClauseTo([NotNull] Cobol85Parser.ClassClauseToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClassCondition([NotNull] Cobol85Parser.ClassConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClassName([NotNull] Cobol85Parser.ClassNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCloseFile([NotNull] Cobol85Parser.CloseFileContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClosePortFileIOStatement([NotNull] Cobol85Parser.ClosePortFileIOStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClosePortFileIOUsing([NotNull] Cobol85Parser.ClosePortFileIOUsingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClosePortFileIOUsingAssociatedData([NotNull] Cobol85Parser.ClosePortFileIOUsingAssociatedDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClosePortFileIOUsingAssociatedDataLength([NotNull] Cobol85Parser.ClosePortFileIOUsingAssociatedDataLengthContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitClosePortFileIOUsingCloseDisposition([NotNull] Cobol85Parser.ClosePortFileIOUsingCloseDispositionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCloseReelUnitStatement([NotNull] Cobol85Parser.CloseReelUnitStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCloseRelativeStatement([NotNull] Cobol85Parser.CloseRelativeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCloseStatement([NotNull] Cobol85Parser.CloseStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCobolWord([NotNull] Cobol85Parser.CobolWordContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCodeSetClause([NotNull] Cobol85Parser.CodeSetClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCollatingSequenceClause([NotNull] Cobol85Parser.CollatingSequenceClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCollatingSequenceClauseAlphanumeric([NotNull] Cobol85Parser.CollatingSequenceClauseAlphanumericContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCollatingSequenceClauseNational([NotNull] Cobol85Parser.CollatingSequenceClauseNationalContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCombinableCondition([NotNull] Cobol85Parser.CombinableConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCommentEntry([NotNull] Cobol85Parser.CommentEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCommitmentControlClause([NotNull] Cobol85Parser.CommitmentControlClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCommunicationDescriptionEntry([NotNull] Cobol85Parser.CommunicationDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCommunicationDescriptionEntryFormat1([NotNull] Cobol85Parser.CommunicationDescriptionEntryFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCommunicationDescriptionEntryFormat2([NotNull] Cobol85Parser.CommunicationDescriptionEntryFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCommunicationDescriptionEntryFormat3([NotNull] Cobol85Parser.CommunicationDescriptionEntryFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCommunicationSection([NotNull] Cobol85Parser.CommunicationSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCompilationUnit([NotNull] Cobol85Parser.CompilationUnitContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitComputerName([NotNull] Cobol85Parser.ComputerNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitComputeStatement([NotNull] Cobol85Parser.ComputeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitComputeStore([NotNull] Cobol85Parser.ComputeStoreContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCondition([NotNull] Cobol85Parser.ConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitConditionName([NotNull] Cobol85Parser.ConditionNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitConditionNameReference([NotNull] Cobol85Parser.ConditionNameReferenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitConditionNameSubscriptReference([NotNull] Cobol85Parser.ConditionNameSubscriptReferenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitConfigurationSection([NotNull] Cobol85Parser.ConfigurationSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitConfigurationSectionParagraph([NotNull] Cobol85Parser.ConfigurationSectionParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitContinueStatement([NotNull] Cobol85Parser.ContinueStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitCurrencySignClause([NotNull] Cobol85Parser.CurrencySignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataAlignedClause([NotNull] Cobol85Parser.DataAlignedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataBaseSection([NotNull] Cobol85Parser.DataBaseSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataBaseSectionEntry([NotNull] Cobol85Parser.DataBaseSectionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataBlankWhenZeroClause([NotNull] Cobol85Parser.DataBlankWhenZeroClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataCommonOwnLocalClause([NotNull] Cobol85Parser.DataCommonOwnLocalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataDescName([NotNull] Cobol85Parser.DataDescNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataDescriptionEntry([NotNull] Cobol85Parser.DataDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataDescriptionEntryExecSql([NotNull] Cobol85Parser.DataDescriptionEntryExecSqlContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataDescriptionEntryFormat1([NotNull] Cobol85Parser.DataDescriptionEntryFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataDescriptionEntryFormat2([NotNull] Cobol85Parser.DataDescriptionEntryFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataDescriptionEntryFormat3([NotNull] Cobol85Parser.DataDescriptionEntryFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataDivision([NotNull] Cobol85Parser.DataDivisionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataDivisionSection([NotNull] Cobol85Parser.DataDivisionSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataExternalClause([NotNull] Cobol85Parser.DataExternalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataGlobalClause([NotNull] Cobol85Parser.DataGlobalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataIntegerStringClause([NotNull] Cobol85Parser.DataIntegerStringClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataJustifiedClause([NotNull] Cobol85Parser.DataJustifiedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataName([NotNull] Cobol85Parser.DataNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataOccursClause([NotNull] Cobol85Parser.DataOccursClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataOccursSort([NotNull] Cobol85Parser.DataOccursSortContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataOccursTo([NotNull] Cobol85Parser.DataOccursToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataPictureClause([NotNull] Cobol85Parser.DataPictureClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataReceivedByClause([NotNull] Cobol85Parser.DataReceivedByClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataRecordAreaClause([NotNull] Cobol85Parser.DataRecordAreaClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataRecordsClause([NotNull] Cobol85Parser.DataRecordsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataRedefinesClause([NotNull] Cobol85Parser.DataRedefinesClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataRenamesClause([NotNull] Cobol85Parser.DataRenamesClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataSignClause([NotNull] Cobol85Parser.DataSignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataSynchronizedClause([NotNull] Cobol85Parser.DataSynchronizedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataThreadLocalClause([NotNull] Cobol85Parser.DataThreadLocalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataTypeClause([NotNull] Cobol85Parser.DataTypeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataTypeDefClause([NotNull] Cobol85Parser.DataTypeDefClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataUsageClause([NotNull] Cobol85Parser.DataUsageClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataUsingClause([NotNull] Cobol85Parser.DataUsingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataValueClause([NotNull] Cobol85Parser.DataValueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataValueInterval([NotNull] Cobol85Parser.DataValueIntervalContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataValueIntervalFrom([NotNull] Cobol85Parser.DataValueIntervalFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataValueIntervalTo([NotNull] Cobol85Parser.DataValueIntervalToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDataWithLowerBoundsClause([NotNull] Cobol85Parser.DataWithLowerBoundsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDateCompiledParagraph([NotNull] Cobol85Parser.DateCompiledParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDateWrittenParagraph([NotNull] Cobol85Parser.DateWrittenParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDecimalPointClause([NotNull] Cobol85Parser.DecimalPointClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDefaultComputationalSignClause([NotNull] Cobol85Parser.DefaultComputationalSignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDefaultDisplaySignClause([NotNull] Cobol85Parser.DefaultDisplaySignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDeleteStatement([NotNull] Cobol85Parser.DeleteStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDestinationCountClause([NotNull] Cobol85Parser.DestinationCountClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDestinationTableClause([NotNull] Cobol85Parser.DestinationTableClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDisableStatement([NotNull] Cobol85Parser.DisableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDiskSizeClause([NotNull] Cobol85Parser.DiskSizeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDisplayAt([NotNull] Cobol85Parser.DisplayAtContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDisplayOperand([NotNull] Cobol85Parser.DisplayOperandContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDisplayStatement([NotNull] Cobol85Parser.DisplayStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDisplayUpon([NotNull] Cobol85Parser.DisplayUponContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDisplayWith([NotNull] Cobol85Parser.DisplayWithContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDivideByGivingStatement([NotNull] Cobol85Parser.DivideByGivingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDivideGiving([NotNull] Cobol85Parser.DivideGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDivideGivingPhrase([NotNull] Cobol85Parser.DivideGivingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDivideInto([NotNull] Cobol85Parser.DivideIntoContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDivideIntoGivingStatement([NotNull] Cobol85Parser.DivideIntoGivingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDivideIntoStatement([NotNull] Cobol85Parser.DivideIntoStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDivideRemainder([NotNull] Cobol85Parser.DivideRemainderContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitDivideStatement([NotNull] Cobol85Parser.DivideStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEnableStatement([NotNull] Cobol85Parser.EnableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEndKeyClause([NotNull] Cobol85Parser.EndKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEndProgramStatement([NotNull] Cobol85Parser.EndProgramStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEntryStatement([NotNull] Cobol85Parser.EntryStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEnvironmentDivision([NotNull] Cobol85Parser.EnvironmentDivisionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEnvironmentDivisionBody([NotNull] Cobol85Parser.EnvironmentDivisionBodyContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEnvironmentName([NotNull] Cobol85Parser.EnvironmentNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEnvironmentSwitchNameClause([NotNull] Cobol85Parser.EnvironmentSwitchNameClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEnvironmentSwitchNameSpecialNamesStatusPhrase([NotNull] Cobol85Parser.EnvironmentSwitchNameSpecialNamesStatusPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitErrorKeyClause([NotNull] Cobol85Parser.ErrorKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitErrorNode(IErrorNode node)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateAlsoCondition([NotNull] Cobol85Parser.EvaluateAlsoConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateAlsoSelect([NotNull] Cobol85Parser.EvaluateAlsoSelectContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateCondition([NotNull] Cobol85Parser.EvaluateConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateSelect([NotNull] Cobol85Parser.EvaluateSelectContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateStatement([NotNull] Cobol85Parser.EvaluateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateThrough([NotNull] Cobol85Parser.EvaluateThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateValue([NotNull] Cobol85Parser.EvaluateValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateWhen([NotNull] Cobol85Parser.EvaluateWhenContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateWhenOther([NotNull] Cobol85Parser.EvaluateWhenOtherContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitEvaluateWhenPhrase([NotNull] Cobol85Parser.EvaluateWhenPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitExecCicsStatement([NotNull] Cobol85Parser.ExecCicsStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitExecSqlImsStatement([NotNull] Cobol85Parser.ExecSqlImsStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitExecSqlStatement([NotNull] Cobol85Parser.ExecSqlStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitExhibitOperand([NotNull] Cobol85Parser.ExhibitOperandContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitExhibitStatement([NotNull] Cobol85Parser.ExhibitStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitExitStatement([NotNull] Cobol85Parser.ExitStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitExternalClause([NotNull] Cobol85Parser.ExternalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFigurativeConstant([NotNull] Cobol85Parser.FigurativeConstantContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFileControlClause([NotNull] Cobol85Parser.FileControlClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFileControlEntry([NotNull] Cobol85Parser.FileControlEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFileControlParagraph([NotNull] Cobol85Parser.FileControlParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFileDescriptionEntry([NotNull] Cobol85Parser.FileDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFileDescriptionEntryClause([NotNull] Cobol85Parser.FileDescriptionEntryClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFileName([NotNull] Cobol85Parser.FileNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFileSection([NotNull] Cobol85Parser.FileSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFileStatusClause([NotNull] Cobol85Parser.FileStatusClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFunctionCall([NotNull] Cobol85Parser.FunctionCallContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFunctionName([NotNull] Cobol85Parser.FunctionNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitGenerateStatement([NotNull] Cobol85Parser.GenerateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitGlobalClause([NotNull] Cobol85Parser.GlobalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitGobackStatement([NotNull] Cobol85Parser.GobackStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitGoToDependingOnStatement([NotNull] Cobol85Parser.GoToDependingOnStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitGoToStatement([NotNull] Cobol85Parser.GoToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitGoToStatementSimple([NotNull] Cobol85Parser.GoToStatementSimpleContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIdentificationDivision([NotNull] Cobol85Parser.IdentificationDivisionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIdentificationDivisionBody([NotNull] Cobol85Parser.IdentificationDivisionBodyContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIdentifier([NotNull] Cobol85Parser.IdentifierContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIfElse([NotNull] Cobol85Parser.IfElseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIfStatement([NotNull] Cobol85Parser.IfStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIfThen([NotNull] Cobol85Parser.IfThenContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInData([NotNull] Cobol85Parser.InDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIndexName([NotNull] Cobol85Parser.IndexNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInFile([NotNull] Cobol85Parser.InFileContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInitializeReplacingBy([NotNull] Cobol85Parser.InitializeReplacingByContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInitializeReplacingPhrase([NotNull] Cobol85Parser.InitializeReplacingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInitializeStatement([NotNull] Cobol85Parser.InitializeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInitiateStatement([NotNull] Cobol85Parser.InitiateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInLibrary([NotNull] Cobol85Parser.InLibraryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInMnemonic([NotNull] Cobol85Parser.InMnemonicContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInputOutputSection([NotNull] Cobol85Parser.InputOutputSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInputOutputSectionParagraph([NotNull] Cobol85Parser.InputOutputSectionParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInSection([NotNull] Cobol85Parser.InSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectAllLeading([NotNull] Cobol85Parser.InspectAllLeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectAllLeadings([NotNull] Cobol85Parser.InspectAllLeadingsContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectBeforeAfter([NotNull] Cobol85Parser.InspectBeforeAfterContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectBy([NotNull] Cobol85Parser.InspectByContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectCharacters([NotNull] Cobol85Parser.InspectCharactersContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectConvertingPhrase([NotNull] Cobol85Parser.InspectConvertingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectFor([NotNull] Cobol85Parser.InspectForContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectReplacingAllLeading([NotNull] Cobol85Parser.InspectReplacingAllLeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectReplacingAllLeadings([NotNull] Cobol85Parser.InspectReplacingAllLeadingsContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectReplacingCharacters([NotNull] Cobol85Parser.InspectReplacingCharactersContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectReplacingPhrase([NotNull] Cobol85Parser.InspectReplacingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectStatement([NotNull] Cobol85Parser.InspectStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectTallyingPhrase([NotNull] Cobol85Parser.InspectTallyingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectTallyingReplacingPhrase([NotNull] Cobol85Parser.InspectTallyingReplacingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInspectTo([NotNull] Cobol85Parser.InspectToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInstallationParagraph([NotNull] Cobol85Parser.InstallationParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInTable([NotNull] Cobol85Parser.InTableContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIntegerLiteral([NotNull] Cobol85Parser.IntegerLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitInvalidKeyPhrase([NotNull] Cobol85Parser.InvalidKeyPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIoControlClause([NotNull] Cobol85Parser.IoControlClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitIoControlParagraph([NotNull] Cobol85Parser.IoControlParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLabelRecordsClause([NotNull] Cobol85Parser.LabelRecordsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLanguageName([NotNull] Cobol85Parser.LanguageNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLength([NotNull] Cobol85Parser.LengthContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryAttributeClauseFormat1([NotNull] Cobol85Parser.LibraryAttributeClauseFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryAttributeClauseFormat2([NotNull] Cobol85Parser.LibraryAttributeClauseFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryAttributeFunction([NotNull] Cobol85Parser.LibraryAttributeFunctionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryAttributeParameter([NotNull] Cobol85Parser.LibraryAttributeParameterContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryAttributeTitle([NotNull] Cobol85Parser.LibraryAttributeTitleContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryDescriptionEntry([NotNull] Cobol85Parser.LibraryDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryDescriptionEntryFormat1([NotNull] Cobol85Parser.LibraryDescriptionEntryFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryDescriptionEntryFormat2([NotNull] Cobol85Parser.LibraryDescriptionEntryFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryEntryProcedureClauseFormat1([NotNull] Cobol85Parser.LibraryEntryProcedureClauseFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryEntryProcedureClauseFormat2([NotNull] Cobol85Parser.LibraryEntryProcedureClauseFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryEntryProcedureForClause([NotNull] Cobol85Parser.LibraryEntryProcedureForClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryEntryProcedureGivingClause([NotNull] Cobol85Parser.LibraryEntryProcedureGivingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryEntryProcedureUsingClause([NotNull] Cobol85Parser.LibraryEntryProcedureUsingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryEntryProcedureUsingName([NotNull] Cobol85Parser.LibraryEntryProcedureUsingNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryEntryProcedureWithClause([NotNull] Cobol85Parser.LibraryEntryProcedureWithClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryEntryProcedureWithName([NotNull] Cobol85Parser.LibraryEntryProcedureWithNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryIsCommonClause([NotNull] Cobol85Parser.LibraryIsCommonClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryIsGlobalClause([NotNull] Cobol85Parser.LibraryIsGlobalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLibraryName([NotNull] Cobol85Parser.LibraryNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLinageAt([NotNull] Cobol85Parser.LinageAtContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLinageClause([NotNull] Cobol85Parser.LinageClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLinageFootingAt([NotNull] Cobol85Parser.LinageFootingAtContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLinageLinesAtBottom([NotNull] Cobol85Parser.LinageLinesAtBottomContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLinageLinesAtTop([NotNull] Cobol85Parser.LinageLinesAtTopContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLinkageSection([NotNull] Cobol85Parser.LinkageSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLiteral([NotNull] Cobol85Parser.LiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLocalName([NotNull] Cobol85Parser.LocalNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitLocalStorageSection([NotNull] Cobol85Parser.LocalStorageSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMemorySizeClause([NotNull] Cobol85Parser.MemorySizeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeCollatingAlphanumeric([NotNull] Cobol85Parser.MergeCollatingAlphanumericContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeCollatingNational([NotNull] Cobol85Parser.MergeCollatingNationalContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeCollatingSequencePhrase([NotNull] Cobol85Parser.MergeCollatingSequencePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeGiving([NotNull] Cobol85Parser.MergeGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeGivingPhrase([NotNull] Cobol85Parser.MergeGivingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeOnKeyClause([NotNull] Cobol85Parser.MergeOnKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeOutputProcedurePhrase([NotNull] Cobol85Parser.MergeOutputProcedurePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeOutputThrough([NotNull] Cobol85Parser.MergeOutputThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeStatement([NotNull] Cobol85Parser.MergeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMergeUsing([NotNull] Cobol85Parser.MergeUsingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMessageCountClause([NotNull] Cobol85Parser.MessageCountClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMessageDateClause([NotNull] Cobol85Parser.MessageDateClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMessageTimeClause([NotNull] Cobol85Parser.MessageTimeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMnemonicName([NotNull] Cobol85Parser.MnemonicNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitModeStatement([NotNull] Cobol85Parser.ModeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMoveCorrespondingToSendingArea([NotNull] Cobol85Parser.MoveCorrespondingToSendingAreaContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMoveCorrespondingToStatement([NotNull] Cobol85Parser.MoveCorrespondingToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMoveStatement([NotNull] Cobol85Parser.MoveStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMoveToSendingArea([NotNull] Cobol85Parser.MoveToSendingAreaContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMoveToStatement([NotNull] Cobol85Parser.MoveToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultDiv([NotNull] Cobol85Parser.MultDivContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultDivs([NotNull] Cobol85Parser.MultDivsContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultipleFileClause([NotNull] Cobol85Parser.MultipleFileClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultipleFilePosition([NotNull] Cobol85Parser.MultipleFilePositionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultiplyGiving([NotNull] Cobol85Parser.MultiplyGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultiplyGivingOperand([NotNull] Cobol85Parser.MultiplyGivingOperandContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultiplyGivingResult([NotNull] Cobol85Parser.MultiplyGivingResultContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultiplyRegular([NotNull] Cobol85Parser.MultiplyRegularContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultiplyRegularOperand([NotNull] Cobol85Parser.MultiplyRegularOperandContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitMultiplyStatement([NotNull] Cobol85Parser.MultiplyStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitNotAtEndPhrase([NotNull] Cobol85Parser.NotAtEndPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitNotInvalidKeyPhrase([NotNull] Cobol85Parser.NotInvalidKeyPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitNotOnExceptionClause([NotNull] Cobol85Parser.NotOnExceptionClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitNotOnOverflowPhrase([NotNull] Cobol85Parser.NotOnOverflowPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitNotOnSizeErrorPhrase([NotNull] Cobol85Parser.NotOnSizeErrorPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitNumericLiteral([NotNull] Cobol85Parser.NumericLiteralContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitObjectComputerClause([NotNull] Cobol85Parser.ObjectComputerClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitObjectComputerParagraph([NotNull] Cobol85Parser.ObjectComputerParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOdtClause([NotNull] Cobol85Parser.OdtClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOnExceptionClause([NotNull] Cobol85Parser.OnExceptionClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOnOverflowPhrase([NotNull] Cobol85Parser.OnOverflowPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOnSizeErrorPhrase([NotNull] Cobol85Parser.OnSizeErrorPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOpenExtendStatement([NotNull] Cobol85Parser.OpenExtendStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOpenInput([NotNull] Cobol85Parser.OpenInputContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOpenInputStatement([NotNull] Cobol85Parser.OpenInputStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOpenIOStatement([NotNull] Cobol85Parser.OpenIOStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOpenOutput([NotNull] Cobol85Parser.OpenOutputContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOpenOutputStatement([NotNull] Cobol85Parser.OpenOutputStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOpenStatement([NotNull] Cobol85Parser.OpenStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitOrganizationClause([NotNull] Cobol85Parser.OrganizationClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPaddingCharacterClause([NotNull] Cobol85Parser.PaddingCharacterClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitParagraph([NotNull] Cobol85Parser.ParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitParagraphName([NotNull] Cobol85Parser.ParagraphNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitParagraphs([NotNull] Cobol85Parser.ParagraphsContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPasswordClause([NotNull] Cobol85Parser.PasswordClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformAfter([NotNull] Cobol85Parser.PerformAfterContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformBy([NotNull] Cobol85Parser.PerformByContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformFrom([NotNull] Cobol85Parser.PerformFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformInlineStatement([NotNull] Cobol85Parser.PerformInlineStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformProcedureStatement([NotNull] Cobol85Parser.PerformProcedureStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformStatement([NotNull] Cobol85Parser.PerformStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformTestClause([NotNull] Cobol85Parser.PerformTestClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformTimes([NotNull] Cobol85Parser.PerformTimesContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformType([NotNull] Cobol85Parser.PerformTypeContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformUntil([NotNull] Cobol85Parser.PerformUntilContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformVarying([NotNull] Cobol85Parser.PerformVaryingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformVaryingClause([NotNull] Cobol85Parser.PerformVaryingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPerformVaryingPhrase([NotNull] Cobol85Parser.PerformVaryingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPictureCardinality([NotNull] Cobol85Parser.PictureCardinalityContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPictureChars([NotNull] Cobol85Parser.PictureCharsContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPictureString([NotNull] Cobol85Parser.PictureStringContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPlusMinus([NotNull] Cobol85Parser.PlusMinusContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPower([NotNull] Cobol85Parser.PowerContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPowers([NotNull] Cobol85Parser.PowersContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDeclarative([NotNull] Cobol85Parser.ProcedureDeclarativeContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDeclaratives([NotNull] Cobol85Parser.ProcedureDeclarativesContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDivision([NotNull] Cobol85Parser.ProcedureDivisionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDivisionBody([NotNull] Cobol85Parser.ProcedureDivisionBodyContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDivisionByReference([NotNull] Cobol85Parser.ProcedureDivisionByReferenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDivisionByReferencePhrase([NotNull] Cobol85Parser.ProcedureDivisionByReferencePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDivisionByValue([NotNull] Cobol85Parser.ProcedureDivisionByValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDivisionByValuePhrase([NotNull] Cobol85Parser.ProcedureDivisionByValuePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDivisionGivingClause([NotNull] Cobol85Parser.ProcedureDivisionGivingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDivisionUsingClause([NotNull] Cobol85Parser.ProcedureDivisionUsingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureDivisionUsingParameter([NotNull] Cobol85Parser.ProcedureDivisionUsingParameterContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureName([NotNull] Cobol85Parser.ProcedureNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureSection([NotNull] Cobol85Parser.ProcedureSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProcedureSectionHeader([NotNull] Cobol85Parser.ProcedureSectionHeaderContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProgramIdParagraph([NotNull] Cobol85Parser.ProgramIdParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProgramLibrarySection([NotNull] Cobol85Parser.ProgramLibrarySectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProgramName([NotNull] Cobol85Parser.ProgramNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitProgramUnit([NotNull] Cobol85Parser.ProgramUnitContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitPurgeStatement([NotNull] Cobol85Parser.PurgeStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitQualifiedDataName([NotNull] Cobol85Parser.QualifiedDataNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitQualifiedDataNameFormat1([NotNull] Cobol85Parser.QualifiedDataNameFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitQualifiedDataNameFormat2([NotNull] Cobol85Parser.QualifiedDataNameFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitQualifiedDataNameFormat3([NotNull] Cobol85Parser.QualifiedDataNameFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitQualifiedDataNameFormat4([NotNull] Cobol85Parser.QualifiedDataNameFormat4Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitQualifiedInData([NotNull] Cobol85Parser.QualifiedInDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReadInto([NotNull] Cobol85Parser.ReadIntoContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReadKey([NotNull] Cobol85Parser.ReadKeyContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReadStatement([NotNull] Cobol85Parser.ReadStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReadWith([NotNull] Cobol85Parser.ReadWithContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveBefore([NotNull] Cobol85Parser.ReceiveBeforeContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveFrom([NotNull] Cobol85Parser.ReceiveFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveFromStatement([NotNull] Cobol85Parser.ReceiveFromStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveIntoStatement([NotNull] Cobol85Parser.ReceiveIntoStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveNoData([NotNull] Cobol85Parser.ReceiveNoDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveSize([NotNull] Cobol85Parser.ReceiveSizeContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveStatement([NotNull] Cobol85Parser.ReceiveStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveStatus([NotNull] Cobol85Parser.ReceiveStatusContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveThread([NotNull] Cobol85Parser.ReceiveThreadContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveWith([NotNull] Cobol85Parser.ReceiveWithContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReceiveWithData([NotNull] Cobol85Parser.ReceiveWithDataContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRecordContainsClause([NotNull] Cobol85Parser.RecordContainsClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRecordContainsClauseFormat1([NotNull] Cobol85Parser.RecordContainsClauseFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRecordContainsClauseFormat2([NotNull] Cobol85Parser.RecordContainsClauseFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRecordContainsClauseFormat3([NotNull] Cobol85Parser.RecordContainsClauseFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRecordContainsTo([NotNull] Cobol85Parser.RecordContainsToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRecordDelimiterClause([NotNull] Cobol85Parser.RecordDelimiterClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRecordingModeClause([NotNull] Cobol85Parser.RecordingModeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRecordKeyClause([NotNull] Cobol85Parser.RecordKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRecordName([NotNull] Cobol85Parser.RecordNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReferenceModifier([NotNull] Cobol85Parser.ReferenceModifierContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRelationalOperator([NotNull] Cobol85Parser.RelationalOperatorContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRelationArithmeticComparison([NotNull] Cobol85Parser.RelationArithmeticComparisonContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRelationCombinedComparison([NotNull] Cobol85Parser.RelationCombinedComparisonContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRelationCombinedCondition([NotNull] Cobol85Parser.RelationCombinedConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRelationCondition([NotNull] Cobol85Parser.RelationConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRelationSignCondition([NotNull] Cobol85Parser.RelationSignConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRelativeKeyClause([NotNull] Cobol85Parser.RelativeKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReleaseStatement([NotNull] Cobol85Parser.ReleaseStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRemarksParagraph([NotNull] Cobol85Parser.RemarksParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportClause([NotNull] Cobol85Parser.ReportClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportDescription([NotNull] Cobol85Parser.ReportDescriptionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportDescriptionEntry([NotNull] Cobol85Parser.ReportDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportDescriptionFirstDetailClause([NotNull] Cobol85Parser.ReportDescriptionFirstDetailClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportDescriptionFootingClause([NotNull] Cobol85Parser.ReportDescriptionFootingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportDescriptionGlobalClause([NotNull] Cobol85Parser.ReportDescriptionGlobalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportDescriptionHeadingClause([NotNull] Cobol85Parser.ReportDescriptionHeadingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportDescriptionLastDetailClause([NotNull] Cobol85Parser.ReportDescriptionLastDetailClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportDescriptionPageLimitClause([NotNull] Cobol85Parser.ReportDescriptionPageLimitClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupBlankWhenZeroClause([NotNull] Cobol85Parser.ReportGroupBlankWhenZeroClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupColumnNumberClause([NotNull] Cobol85Parser.ReportGroupColumnNumberClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupDescriptionEntry([NotNull] Cobol85Parser.ReportGroupDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupDescriptionEntryFormat1([NotNull] Cobol85Parser.ReportGroupDescriptionEntryFormat1Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupDescriptionEntryFormat2([NotNull] Cobol85Parser.ReportGroupDescriptionEntryFormat2Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupDescriptionEntryFormat3([NotNull] Cobol85Parser.ReportGroupDescriptionEntryFormat3Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupIndicateClause([NotNull] Cobol85Parser.ReportGroupIndicateClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupJustifiedClause([NotNull] Cobol85Parser.ReportGroupJustifiedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupLineNumberClause([NotNull] Cobol85Parser.ReportGroupLineNumberClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupLineNumberNextPage([NotNull] Cobol85Parser.ReportGroupLineNumberNextPageContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupLineNumberPlus([NotNull] Cobol85Parser.ReportGroupLineNumberPlusContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupNextGroupClause([NotNull] Cobol85Parser.ReportGroupNextGroupClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupNextGroupNextPage([NotNull] Cobol85Parser.ReportGroupNextGroupNextPageContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupNextGroupPlus([NotNull] Cobol85Parser.ReportGroupNextGroupPlusContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupPictureClause([NotNull] Cobol85Parser.ReportGroupPictureClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupResetClause([NotNull] Cobol85Parser.ReportGroupResetClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupSignClause([NotNull] Cobol85Parser.ReportGroupSignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupSourceClause([NotNull] Cobol85Parser.ReportGroupSourceClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupSumClause([NotNull] Cobol85Parser.ReportGroupSumClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupTypeClause([NotNull] Cobol85Parser.ReportGroupTypeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupTypeControlFooting([NotNull] Cobol85Parser.ReportGroupTypeControlFootingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupTypeControlHeading([NotNull] Cobol85Parser.ReportGroupTypeControlHeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupTypeDetail([NotNull] Cobol85Parser.ReportGroupTypeDetailContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupTypePageFooting([NotNull] Cobol85Parser.ReportGroupTypePageFootingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupTypePageHeading([NotNull] Cobol85Parser.ReportGroupTypePageHeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupTypeReportFooting([NotNull] Cobol85Parser.ReportGroupTypeReportFootingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupTypeReportHeading([NotNull] Cobol85Parser.ReportGroupTypeReportHeadingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupUsageClause([NotNull] Cobol85Parser.ReportGroupUsageClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportGroupValueClause([NotNull] Cobol85Parser.ReportGroupValueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportName([NotNull] Cobol85Parser.ReportNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReportSection([NotNull] Cobol85Parser.ReportSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRerunClause([NotNull] Cobol85Parser.RerunClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRerunEveryClock([NotNull] Cobol85Parser.RerunEveryClockContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRerunEveryOf([NotNull] Cobol85Parser.RerunEveryOfContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRerunEveryRecords([NotNull] Cobol85Parser.RerunEveryRecordsContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReserveClause([NotNull] Cobol85Parser.ReserveClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReserveNetworkClause([NotNull] Cobol85Parser.ReserveNetworkClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReturnInto([NotNull] Cobol85Parser.ReturnIntoContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitReturnStatement([NotNull] Cobol85Parser.ReturnStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRewriteFrom([NotNull] Cobol85Parser.RewriteFromContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRewriteStatement([NotNull] Cobol85Parser.RewriteStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitRoutineName([NotNull] Cobol85Parser.RoutineNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSameClause([NotNull] Cobol85Parser.SameClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionAutoClause([NotNull] Cobol85Parser.ScreenDescriptionAutoClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionBackgroundColorClause([NotNull] Cobol85Parser.ScreenDescriptionBackgroundColorClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionBellClause([NotNull] Cobol85Parser.ScreenDescriptionBellClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionBlankClause([NotNull] Cobol85Parser.ScreenDescriptionBlankClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionBlankWhenZeroClause([NotNull] Cobol85Parser.ScreenDescriptionBlankWhenZeroClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionBlinkClause([NotNull] Cobol85Parser.ScreenDescriptionBlinkClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionColumnClause([NotNull] Cobol85Parser.ScreenDescriptionColumnClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionControlClause([NotNull] Cobol85Parser.ScreenDescriptionControlClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionEntry([NotNull] Cobol85Parser.ScreenDescriptionEntryContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionEraseClause([NotNull] Cobol85Parser.ScreenDescriptionEraseClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionForegroundColorClause([NotNull] Cobol85Parser.ScreenDescriptionForegroundColorClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionFromClause([NotNull] Cobol85Parser.ScreenDescriptionFromClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionFullClause([NotNull] Cobol85Parser.ScreenDescriptionFullClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionGridClause([NotNull] Cobol85Parser.ScreenDescriptionGridClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionJustifiedClause([NotNull] Cobol85Parser.ScreenDescriptionJustifiedClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionLightClause([NotNull] Cobol85Parser.ScreenDescriptionLightClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionLineClause([NotNull] Cobol85Parser.ScreenDescriptionLineClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionPictureClause([NotNull] Cobol85Parser.ScreenDescriptionPictureClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionPromptClause([NotNull] Cobol85Parser.ScreenDescriptionPromptClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionPromptOccursClause([NotNull] Cobol85Parser.ScreenDescriptionPromptOccursClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionRequiredClause([NotNull] Cobol85Parser.ScreenDescriptionRequiredClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionReverseVideoClause([NotNull] Cobol85Parser.ScreenDescriptionReverseVideoClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionSecureClause([NotNull] Cobol85Parser.ScreenDescriptionSecureClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionSignClause([NotNull] Cobol85Parser.ScreenDescriptionSignClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionSizeClause([NotNull] Cobol85Parser.ScreenDescriptionSizeClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionToClause([NotNull] Cobol85Parser.ScreenDescriptionToClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionUnderlineClause([NotNull] Cobol85Parser.ScreenDescriptionUnderlineClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionUsageClause([NotNull] Cobol85Parser.ScreenDescriptionUsageClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionUsingClause([NotNull] Cobol85Parser.ScreenDescriptionUsingClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionValueClause([NotNull] Cobol85Parser.ScreenDescriptionValueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenDescriptionZeroFillClause([NotNull] Cobol85Parser.ScreenDescriptionZeroFillClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenName([NotNull] Cobol85Parser.ScreenNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitScreenSection([NotNull] Cobol85Parser.ScreenSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSearchStatement([NotNull] Cobol85Parser.SearchStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSearchVarying([NotNull] Cobol85Parser.SearchVaryingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSearchWhen([NotNull] Cobol85Parser.SearchWhenContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSectionName([NotNull] Cobol85Parser.SectionNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSecurityParagraph([NotNull] Cobol85Parser.SecurityParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSegmentLimitClause([NotNull] Cobol85Parser.SegmentLimitClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSelectClause([NotNull] Cobol85Parser.SelectClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendAdvancingLines([NotNull] Cobol85Parser.SendAdvancingLinesContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendAdvancingMnemonic([NotNull] Cobol85Parser.SendAdvancingMnemonicContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendAdvancingPage([NotNull] Cobol85Parser.SendAdvancingPageContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendAdvancingPhrase([NotNull] Cobol85Parser.SendAdvancingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendFromPhrase([NotNull] Cobol85Parser.SendFromPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendReplacingPhrase([NotNull] Cobol85Parser.SendReplacingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendStatement([NotNull] Cobol85Parser.SendStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendStatementAsync([NotNull] Cobol85Parser.SendStatementAsyncContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendStatementSync([NotNull] Cobol85Parser.SendStatementSyncContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSendWithPhrase([NotNull] Cobol85Parser.SendWithPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSentence([NotNull] Cobol85Parser.SentenceContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSetByValue([NotNull] Cobol85Parser.SetByValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSetStatement([NotNull] Cobol85Parser.SetStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSetTo([NotNull] Cobol85Parser.SetToContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSetToStatement([NotNull] Cobol85Parser.SetToStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSetToValue([NotNull] Cobol85Parser.SetToValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSetUpDownByStatement([NotNull] Cobol85Parser.SetUpDownByStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSimpleCondition([NotNull] Cobol85Parser.SimpleConditionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortCollatingAlphanumeric([NotNull] Cobol85Parser.SortCollatingAlphanumericContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortCollatingNational([NotNull] Cobol85Parser.SortCollatingNationalContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortCollatingSequencePhrase([NotNull] Cobol85Parser.SortCollatingSequencePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortDuplicatesPhrase([NotNull] Cobol85Parser.SortDuplicatesPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortGiving([NotNull] Cobol85Parser.SortGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortGivingPhrase([NotNull] Cobol85Parser.SortGivingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortInputProcedurePhrase([NotNull] Cobol85Parser.SortInputProcedurePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortInputThrough([NotNull] Cobol85Parser.SortInputThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortOnKeyClause([NotNull] Cobol85Parser.SortOnKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortOutputProcedurePhrase([NotNull] Cobol85Parser.SortOutputProcedurePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortOutputThrough([NotNull] Cobol85Parser.SortOutputThroughContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortStatement([NotNull] Cobol85Parser.SortStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSortUsing([NotNull] Cobol85Parser.SortUsingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSourceComputerParagraph([NotNull] Cobol85Parser.SourceComputerParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSpecialNameClause([NotNull] Cobol85Parser.SpecialNameClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSpecialNamesParagraph([NotNull] Cobol85Parser.SpecialNamesParagraphContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSpecialRegister([NotNull] Cobol85Parser.SpecialRegisterContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStartKey([NotNull] Cobol85Parser.StartKeyContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStartRule([NotNull] Cobol85Parser.StartRuleContext context)
        {
            return $"Visiting StartRule: {context.ChildCount}";
            //context.compilationUnit().Accept(this);
        }

        public object VisitStartStatement([NotNull] Cobol85Parser.StartStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStatement([NotNull] Cobol85Parser.StatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStatusKeyClause([NotNull] Cobol85Parser.StatusKeyClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStopStatement([NotNull] Cobol85Parser.StopStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStringDelimitedByPhrase([NotNull] Cobol85Parser.StringDelimitedByPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStringForPhrase([NotNull] Cobol85Parser.StringForPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStringIntoPhrase([NotNull] Cobol85Parser.StringIntoPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStringSending([NotNull] Cobol85Parser.StringSendingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStringSendingPhrase([NotNull] Cobol85Parser.StringSendingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStringStatement([NotNull] Cobol85Parser.StringStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitStringWithPointerPhrase([NotNull] Cobol85Parser.StringWithPointerPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubscript_([NotNull] Cobol85Parser.Subscript_Context context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubtractCorrespondingStatement([NotNull] Cobol85Parser.SubtractCorrespondingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubtractFromGivingStatement([NotNull] Cobol85Parser.SubtractFromGivingStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubtractFromStatement([NotNull] Cobol85Parser.SubtractFromStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubtractGiving([NotNull] Cobol85Parser.SubtractGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubtractMinuend([NotNull] Cobol85Parser.SubtractMinuendContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubtractMinuendCorresponding([NotNull] Cobol85Parser.SubtractMinuendCorrespondingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubtractMinuendGiving([NotNull] Cobol85Parser.SubtractMinuendGivingContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubtractStatement([NotNull] Cobol85Parser.SubtractStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSubtractSubtrahend([NotNull] Cobol85Parser.SubtractSubtrahendContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSymbolicCharacter([NotNull] Cobol85Parser.SymbolicCharacterContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSymbolicCharacters([NotNull] Cobol85Parser.SymbolicCharactersContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSymbolicCharactersClause([NotNull] Cobol85Parser.SymbolicCharactersClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSymbolicDestinationClause([NotNull] Cobol85Parser.SymbolicDestinationClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSymbolicQueueClause([NotNull] Cobol85Parser.SymbolicQueueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSymbolicSourceClause([NotNull] Cobol85Parser.SymbolicSourceClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSymbolicSubQueueClause([NotNull] Cobol85Parser.SymbolicSubQueueClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSymbolicTerminalClause([NotNull] Cobol85Parser.SymbolicTerminalClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitSystemName([NotNull] Cobol85Parser.SystemNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitTableCall([NotNull] Cobol85Parser.TableCallContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitTerminal(ITerminalNode node)
        {
            throw new System.NotImplementedException();
        }

        public object VisitTerminateStatement([NotNull] Cobol85Parser.TerminateStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitTextLengthClause([NotNull] Cobol85Parser.TextLengthClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitTextName([NotNull] Cobol85Parser.TextNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringCountIn([NotNull] Cobol85Parser.UnstringCountInContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringDelimitedByPhrase([NotNull] Cobol85Parser.UnstringDelimitedByPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringDelimiterIn([NotNull] Cobol85Parser.UnstringDelimiterInContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringInto([NotNull] Cobol85Parser.UnstringIntoContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringIntoPhrase([NotNull] Cobol85Parser.UnstringIntoPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringOrAllPhrase([NotNull] Cobol85Parser.UnstringOrAllPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringSendingPhrase([NotNull] Cobol85Parser.UnstringSendingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringStatement([NotNull] Cobol85Parser.UnstringStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringTallyingPhrase([NotNull] Cobol85Parser.UnstringTallyingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUnstringWithPointerPhrase([NotNull] Cobol85Parser.UnstringWithPointerPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUseAfterClause([NotNull] Cobol85Parser.UseAfterClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUseAfterOn([NotNull] Cobol85Parser.UseAfterOnContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUseDebugClause([NotNull] Cobol85Parser.UseDebugClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUseDebugOn([NotNull] Cobol85Parser.UseDebugOnContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitUseStatement([NotNull] Cobol85Parser.UseStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitValueOfClause([NotNull] Cobol85Parser.ValueOfClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitValuePair([NotNull] Cobol85Parser.ValuePairContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitWorkingStorageSection([NotNull] Cobol85Parser.WorkingStorageSectionContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitWriteAdvancingLines([NotNull] Cobol85Parser.WriteAdvancingLinesContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitWriteAdvancingMnemonic([NotNull] Cobol85Parser.WriteAdvancingMnemonicContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitWriteAdvancingPage([NotNull] Cobol85Parser.WriteAdvancingPageContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitWriteAdvancingPhrase([NotNull] Cobol85Parser.WriteAdvancingPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitWriteAtEndOfPagePhrase([NotNull] Cobol85Parser.WriteAtEndOfPagePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitWriteFromPhrase([NotNull] Cobol85Parser.WriteFromPhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitWriteNotAtEndOfPagePhrase([NotNull] Cobol85Parser.WriteNotAtEndOfPagePhraseContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitWriteStatement([NotNull] Cobol85Parser.WriteStatementContext context)
        {
            throw new System.NotImplementedException();
        }
    }

}
